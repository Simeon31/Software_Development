using System;
using System.Collections.Generic;
using System.Text;

namespace PoolPipes.Views
{
    public class Display
    {
        public int V { get; set; }
        public int Pipe01 { get; set; }
        public int Pipe02 { get; set; }
        public double Hours { get; set; }
        public double Pipe01Work { get; set; }
        public double Pipe02Work { get; set; }
        public double State { get; set; }

        private double totalLiters;
        public Display()
        {
            V = int.Parse(Console.ReadLine());
            Pipe01 = int.Parse(Console.ReadLine());
            Pipe02 = int.Parse(Console.ReadLine());
            Hours = double.Parse(Console.ReadLine());
        }

        public void DisplayStateOfPool()
        {
            totalLiters = (Pipe01 * Hours) + (Pipe02 * Hours);

            if (totalLiters <= V)
            {
                Console.WriteLine($"The pool is {State}% full. Pipe 1: {Pipe01Work}%. Pipe 2: {Pipe02Work}%.");
            }
            else
            {
                Console.WriteLine($"For {Hours} hours the pool overflows with {State} liters.");
            }
        }
    }
}
