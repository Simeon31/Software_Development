using System;
using System.Collections.Generic;
using System.Text;

namespace Vacancy.Model
{
    class Holiday
    {
        private double budged;
        private string freeTime;

        private double Budged
        {
            get
            {
                return budged;
            }
            set
            {
                budged = value;
            }
        }
        private string FreeTime
        {
            get
            {
                return $"{freeTime}";
            }
            set
            {
                if (value.Equals("summer") || value.Equals("winter"))
                {
                    freeTime = value;
                }
                else
                {
                    throw new Exception("Valid seasons: summer and winter");
                }
            }
        }

        public Holiday(double budged, string freeTime)
        {
            Budged = budged;
            FreeTime = freeTime;
        }

        public double CalculateBudged()
        {
            double expenses = 0.0;

            if (Budged <= 100)
            {
                if (FreeTime.Equals("summer"))
                {
                    expenses = budged * 0.30;
                }
                else
                {
                    expenses = budged * 0.70;
                }
            }
            else if (Budged <= 1000)
            {
                if (FreeTime.Equals("summer"))
                {
                    expenses = budged * 0.40;
                }
                else
                {
                    expenses = budged * 0.80;
                }
            }
            else
            {
                if (FreeTime.Equals("summer"))
                {
                    expenses = budged * 0.90;
                }
                else
                {
                    expenses = budged * 0.90;
                }
            }

            return Math.Round(expenses, 2);
        }
    }
}
