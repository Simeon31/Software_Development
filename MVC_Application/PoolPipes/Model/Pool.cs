using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPipes.Model
{
    public class Pool
    {
        private int V { get; set; }
        private int Pipe01 { get; set; }
        private int Pipe02 { get; set; }
        private double hour;
        double litersOfPipe01;
        double litersOfPipe02;
        double totalLiters;
        double pipe01Work;
        double pipe02Work;
        double state;

        private double Hours
        {
            get
            {
                return hour;
            }
            set
            {
                if (value > 24.0)
                {
                    throw new ArgumentException("Invalid hour!");
                }
                else
                {
                    hour = value;
                }
            }
        }

        public Pool(int v, int pipe01, int pipe02, double h)
        {
            V = v;
            Pipe01 = pipe01;
            Pipe02 = pipe02;
            Hours = h;
        }

        public double TotalLiters()
        {
            litersOfPipe01 = Pipe01 * Hours;
            litersOfPipe02 = Pipe02 * Hours;
            totalLiters = litersOfPipe01 + litersOfPipe02;

            return totalLiters;
        }
        public double StateOfPool()
        {
            state = 0.0;

            if (TotalLiters() <= V)
            {
                state = ((double)(TotalLiters() / V)) * 100;
                // i.e. percents of full
            }
            else if (TotalLiters() > V)
            {
                state = TotalLiters() - V;
                // i.e. the pool overflowed.
            }

            return (int)state;
        }

        public double Pipe01Work()
        {
            pipe01Work = (litersOfPipe01 / TotalLiters()) * 100;

            return (int)pipe01Work;
        }
        public double Pipe02Work()
        {
            pipe02Work = (litersOfPipe02 / TotalLiters()) * 100;

            return (int)pipe02Work;
        }
    }
}
