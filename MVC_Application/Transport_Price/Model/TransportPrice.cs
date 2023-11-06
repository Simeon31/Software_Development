using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Applications.Model
{
    class TransportPrice
    {
        private int distance;
        private string dayTime;
        private double cheapestPrice;

        public int Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }
        public string DayTime
        {
            get
            {
                return dayTime;
            }
            set
            {
                dayTime = value;
            }
        }
        public double CheapestPrice
        {
            get
            {
                return cheapestPrice;
            }
            set
            {
                cheapestPrice = value;
            }
        }

        public TransportPrice(int distance, string dayTime)
        {
            Distance = distance;
            DayTime = dayTime;
        }
        public double CalculateLowestTransportPrice()
        {
            double startTaxiPrice = 0.70;
            double busPrice = 0.09;
            double trainPrice = 0.06;

            switch (DayTime)
            {
                case "day":
                    if (Distance < 20)
                    {
                        double dailyTaxiPrice = 0.79;
                        CheapestPrice = startTaxiPrice + (Distance * dailyTaxiPrice);
                    }
                    else if (Distance < 100)
                    {
                        CheapestPrice = Distance * busPrice;
                    }
                    else
                    {
                        CheapestPrice = Distance * trainPrice;
                    }
                    break;

                case "night":
                    if (Distance < 20)
                    {
                        double nightlyTaxiPrice = 0.90;
                        CheapestPrice = startTaxiPrice + (Distance * nightlyTaxiPrice);
                    }
                    else if (Distance < 100)
                    {
                        CheapestPrice = Distance * busPrice;
                    }
                    else
                    {
                        CheapestPrice = Distance * trainPrice;
                    }
                    break;

                default:
                    Console.WriteLine("Not valid period");
                    break;
            }
            return CheapestPrice;
        }
    }
}
