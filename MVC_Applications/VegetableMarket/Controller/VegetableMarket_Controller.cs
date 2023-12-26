using System;
using System.Collections.Generic;
using System.Text;
using Vegetable_Market.Model;
using Vegetable_Market.Views;

namespace Vegetable_Market.Controller
{
    class VegetableMarket_Controller
    {
        Display display;
        VeggieMarket veggiMarket;

        public VegetableMarket_Controller()
        {
            display = new Display();
            veggiMarket = new VeggieMarket(display.PricePerKgForVeggitables, display.PricePerKgForFruits, display.KgOfVeggies, display.KgOfFruits);
            display.price = veggiMarket.CalculatePrice();
            display.CalculateTotalPrice();
        }
    }
}
