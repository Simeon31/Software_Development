using System;

namespace TilesRepairing.Model
{
    class Repairment
    {
        private int N { get; set; }
        private double W { get; set; }
        private double L { get; set; }
        private int M { get; set; }
        private int O { get; set; }

        public Repairment(int n, double w, double l, int m, int o)
        {
            N = n;
            W = w;
            L = l;
            M = m;
            O = o;
        }

        private double CalculateTotalArea()
        {
            return N * N;
        }
        private double CalculatedAreaToBeCovered()
        {
            int benchArea = M * O;
            double areaToBeCovered = CalculateTotalArea() - benchArea;
            return areaToBeCovered;
        }

        private double CalculateTilesArea()
        {
            return W * L;
        }
        public double NecessaryTiles()
        {
            return CalculatedAreaToBeCovered() / CalculateTilesArea();
        }
        public double NecessaryTime()
        {
            return (NecessaryTiles() * CalculateTilesArea()) / 100;
        }
    }
}
