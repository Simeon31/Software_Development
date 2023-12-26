using System;
using System.Collections.Generic;
using System.Text;

namespace Division.Views
{
    class Display
    {
        public int n;
        public int[] arr;
        public double[] Result { get; set; }
        public Display()
        {
            n = int.Parse(Console.ReadLine());
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void PrintResult()
        {
            foreach (double item in Result)
            {
                Console.WriteLine("{0:F2}% ", item);
            }
        }
    }
}
