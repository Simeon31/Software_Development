using System;
using System.Collections.Generic;
using System.Text;

namespace Division.Model
{
    class Calculation
    {
        private double[] percents;

        public Calculation()
        {
            percents = new double[4];
        }

        public double[] Devide(int n, int[] arr)
        {
            int[] counts = new int[4];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    counts[0]++;
                    percents[0] = ((double)counts[0] / n) * 100;
                }
                if (arr[i] % 3 == 0)
                {
                    counts[1]++;
                    percents[1] = ((double)counts[1] / n) * 100;
                }
                if (arr[i] % 4 == 0)
                {
                    counts[2]++;
                    percents[2] = ((double)counts[2] / n) * 100;
                }
            }

            return percents;
        }
    }
}
