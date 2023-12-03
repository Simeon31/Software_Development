using System;
using System.Collections.Generic;
using System.Text;

namespace TilesRepairing.Views
{
    class Display
    {
        public int N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public int M { get; set; }
        public int O { get; set; }

        public double NecessaryTiles { get; set; }
        public double NecessaryTime { get; set; }

        public Display()
        {
            N = int.Parse(Console.ReadLine());
            W = double.Parse(Console.ReadLine());
            L = double.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            O = int.Parse(Console.ReadLine());
            NecessaryTiles = 0.0;
            NecessaryTime = 0.0;
        }

        public void Print()
        {
            Console.WriteLine($"{NecessaryTiles:F2}");
            Console.WriteLine($"{NecessaryTime:F2}");
        }
    }
}
