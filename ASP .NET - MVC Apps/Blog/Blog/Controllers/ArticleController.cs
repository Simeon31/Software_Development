using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        // GET: List
        public ActionResult List()
        {
            // Get articles from the database
            using (BlogDbContext database = new BlogDbContext())
            {
                var articles = database.Articles.Include(a => a.Author).ToList();

                return View(articles);
            }
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            // Get the article from the database
            using (BlogDbContext database = new BlogDbContext())
            {
                // Fetching the article
                var article = database.Articles.Where(a => a.Id == id).Include(a => a.Author).First();

                if (article == null)
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        // GET: Article/Create
        [Authorize]
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: Article/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                // Insert article in the database
                using (BlogDbContext database = new BlogDbContext())
                {
                    // Get author id
                    var authorId = database.Users.Where(u => u.UserName == this.User.Identity.Name).First().Id;

                    // Set article's author
                    article.AuthorId = authorId;

                    // Save article in DB
                    database.Articles.Add(article);
                    database.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(article);
        }

        // GET: Aticle/Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (BlogDbContext database = new BlogDbContext())
            {
                // Get article from database
                Article article = database.Articles.Where(a => a.Id == id).Include(a => a.Author).First();

                if (!IsUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                // Check if article exists
                if (article == null)
                {
                    return HttpNotFound();
                }

                // Pass article to view
                return View(article);
            }
        }

        // Post: Article/Delete
        [HttpPost]
        [ActionName("Delete")]

        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (BlogDbContext database = new BlogDbContext())
            {
                // Get article from the database
                Article article = database.Articles.Where(a => a.Id == id).Include(a => a.Author).First();

                // Chech if article exists
                if (article == null)
                {
                    return HttpNotFound();
                }

                // Remove article
                database.Articles.Remove(article);
                database.SaveChanges();

                // Redirect to index page

                return RedirectToAction("Index");
            }
        }

        private bool IsUserAuthorizedToEdit(Article article)
        {
            bool isAdmin = User.IsInRole("Admin");
            bool isAuthor = article.IsAuthor(User.Identity.Name);

            return isAdmin || isAuthor;
        }
        // GET: Article/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (BlogDbContext database = new BlogDbContext())
            {
                // Get article from database
                Article article = database.Articles.Where(a => a.Id == id).First();


                if (!IsUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                // Check if article exists
                if (article == null)
                {
                    return HttpNotFound();
                }

                // Create the view model
                ArticleViewModel articleViewModel = new ArticleViewModel();

                articleViewModel.Id = article.Id;
                articleViewModel.Title = article.Title;
                articleViewModel.Content = article.Content;

                // Pass the view model to the view
                return View(articleViewModel);
            }
        }

        // POST: Article/Edit
        [HttpPost]
        public ActionResult Edit(ArticleViewModel model)
        {
            // Check if model state is valid
            if (ModelState.IsValid)
            {
                using (BlogDbContext database = new BlogDbContext())
                {
                    // Get article from database
                    Article article = database.Articles.FirstOrDefault(a => a.Id == model.Id);

                    // Set article properties
                    article.Title = model.Title;
                    article.Content = model.Content;

                    // Save article's state
                    database.Entry(article).State = EntityState.Modified;
                    database.SaveChanges();

                    // Redirect to index
                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }
    }
}