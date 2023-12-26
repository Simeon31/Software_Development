using System;
using System.Collections.Generic;
using System.Text;
using _Histogram.Model;
using _Histogram.Views;

namespace _Histogram.Controllers
{
    class Histogram_Controller
    {
        Histogram histogram;
        Display display;

        public Histogram_Controller()
        {
            histogram = new Histogram();
            display = new Display();
            display.Percentages = histogram.CalculateHistogram(display.Number, display.Data);
            display.PrintPercentages();
        }
    }
}
