using System;
using System.Collections.Generic;
using System.Text;

namespace Vacancy.Views
{
    class Display
    {
        public double Budged { get; set; }
        public string Seasson { get; set; }
        public double Expences { get; set; }

        public Display()
        {
            Budged = double.Parse(Console.ReadLine());
            Seasson = Console.ReadLine();
            Expences = 0.0;
        }

        public void PlanVacancy()
        {
            if (Budged <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (Seasson.Equals("summer"))
                {
                    Console.WriteLine("Camp - {0:F2}", Expences);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:F2}", Expences);
                }
            }
            else if (Budged <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (Seasson.Equals("summer"))
                {
                    Console.WriteLine("Camp - {0:F2}", Expences);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:F2}", Expences);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");

                if (Seasson.Equals("summer"))
                {
                    Console.WriteLine("Camp - {0:F2}", Expences);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:F2}", Expences);
                }
            }
        }
    }
}
