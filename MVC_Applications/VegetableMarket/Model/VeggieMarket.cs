using System;
using System.Collections.Generic;
using System.Text;

namespace Vegetable_Market.Model
{
    class VeggieMarket
    {
        private double earnings;
        private double PricePerKgForVeggies { get; set; }
        private double PricePerKgForFruits { get; set; }
        private int KgOfVeggitables { get; set; }
        private int KgOfFuits { get; set; }

        public VeggieMarket(double pricePerKgForVeggitables, double pricePerKgForFruits, int kgOfVeggies, int kgOfFruits)
        {
            PricePerKgForVeggies = pricePerKgForVeggitables;
            PricePerKgForFruits = pricePerKgForFruits;
            KgOfVeggitables = kgOfVeggies;
            KgOfFuits = kgOfFruits;
        }

        public double CalculatePrice()
        {
            double totalVegitablesPrice = PricePerKgForVeggies * KgOfVeggitables;
            double totalFruitsPrice = PricePerKgForFruits * KgOfFuits;

            earnings = totalVegitablesPrice + totalFruitsPrice;
            double priceInEuro = earnings / 1.94;

            return priceInEuro;
        }
    }
}
