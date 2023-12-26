using System;
using System.Collections.Generic;
using System.Text;

namespace _Histogram.Views
{
    class Display
    {
        public int Number { get; set; }
        public int[] Data { get; set; }
        private double[] percentages;
        public Display()
        {
            Number = int.Parse(Console.ReadLine());
            Data = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Data[i] = int.Parse(Console.ReadLine());
            }
        }
        public double[] Percentages
        {
            get
            {
                return percentages;
            }
            set
            {
                percentages = value;
            }
        }

        public void PrintPercentages()
        {
            foreach (double percentage in Percentages)
            {
                Console.WriteLine("{0:F2}%", percentage);
            }
        }
    }
}
