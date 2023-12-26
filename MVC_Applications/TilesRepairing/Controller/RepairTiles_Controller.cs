using System;
using System.Collections.Generic;
using System.Text;
using TilesRepairing.Model;
using TilesRepairing.Views;

namespace TilesRepairing.Controller
{
    class RepairTiles_Controller
    {
        Display display;
        Repairment square;

        public RepairTiles_Controller()
        {
            display = new Display();
            square = new Repairment(display.N, display.W, display.L, display.M, display.O);
            display.NecessaryTiles = square.NecessaryTiles();
            display.NecessaryTime = square.NecessaryTime();
            display.Print();
        }
    }
}
