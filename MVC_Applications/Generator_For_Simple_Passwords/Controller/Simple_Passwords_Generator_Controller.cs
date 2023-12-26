using System;
using Generator_For_Simple_Passwords.Model;
using Generator_For_Simple_Passwords.Views;

namespace Generator_For_Simple_Passwords.Controller
{
    class Simple_Passwords_Generator_Controller
    {
        Display display;
        Generator generator;

        public Simple_Passwords_Generator_Controller()
        {
            display = new Display();
            generator = new Generator();
            display.Passwords = generator.Generate(display.n, display.l);
            display.Print();
        }
    }
}
