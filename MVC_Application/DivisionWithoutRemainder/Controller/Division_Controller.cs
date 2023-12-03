using System;
using System.Collections.Generic;
using System.Text;
using Division.Model;
using Division.Views;

namespace Division.Controller
{
    class Division_Controller
    {
        Calculation calculation;
        Display display;

        public Division_Controller()
        {
            display = new Display();
            calculation = new Calculation();
            display.Result = calculation.Devide(display.n, display.arr);
            display.PrintResult();
        }
    }
}
