using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_Market.Views
{
    class Display
    {
        public double price;
        public double PricePerKgForVeggitables { get; set; }
        public double PricePerKgForFruits { get; set; }
        public int KgOfVeggies { get; set; }
        public int KgOfFruits { get; set; }
        public Display()
        {
            PricePerKgForVeggitables = double.Parse(Console.ReadLine());
            PricePerKgForFruits = double.Parse(Console.ReadLine());
            KgOfVeggies = int.Parse(Console.ReadLine());
            KgOfFruits = int.Parse(Console.ReadLine());
            price = 0.0;
        }

        public void CalculateTotalPrice()
        {
            Console.WriteLine("Total price: {0} euro.", Math.Round(price, 2));
        }
    }
}
