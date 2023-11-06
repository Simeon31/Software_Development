using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Applications.Views
{
    class Display
    {
        public int Distance { get; set; }
        public string DayTime { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            Distance = int.Parse(Console.ReadLine());
            DayTime = Console.ReadLine();
        }
        public Display()
        {
            Distance = 0;
            DayTime = null;
            TotalPrice = 0.0;
            GetValues();
        }

        public void PrintPrice()
        {
            Console.WriteLine("Cheapest price: {0:F2} ", TotalPrice);
        }
    }
}
