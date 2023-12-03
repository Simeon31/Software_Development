using System;
using System.Collections.Generic;
using System.Text;
using Vacancy.Model;
using Vacancy.Views;

namespace Vacancy.Controller
{
    class Vacancy_Controller
    {
        Holiday holiday;
        Display display;

        public Vacancy_Controller()
        {
            display = new Display();
            holiday = new Holiday(display.Budged, display.Seasson);
            display.Expences = holiday.CalculateBudged();
            display.PlanVacancy();
        }
    }
}
