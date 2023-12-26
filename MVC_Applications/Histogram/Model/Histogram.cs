using System;
using System.Collections.Generic;
using System.Text;

namespace _Histogram.Model
{
    class Histogram
    {
        private double[] percents;
        public Histogram()
        {
            percents = new double[5];
        }
        public double[] CalculateHistogram(int n, int[] arr)
        {
            int[] count = new int[5];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 200)
                {
                    count[0]++;
                    percents[0] = ((double)count[0] / n) * 100;
                }
                else if (arr[i] >= 200 && arr[i] <= 399)
                {
                    count[1]++;
                    percents[1] = ((double)count[1] / n) * 100;
                }
                else if (arr[i] >= 400 && arr[i] <= 599)
                {
                    count[2]++;
                    percents[2] = ((double)count[2] / n) * 100;
                }
                else if (arr[i] >= 600 && arr[i] <= 799)
                {
                    count[3]++;
                    percents[3] = ((double)count[3] / n) * 100;
                }
                else
                {
                    count[4]++;
                    percents[4] = ((double)count[4] / n) * 100;
                }
            }
            return percents;
        }
    }
}
