using System;
using System.Collections.Generic;
using System.Text;
using PoolPipes.Model;
using PoolPipes.Views;

namespace PoolPipes.Controller
{
    public class PoolPipes_Controller
    {
        Display display;
        Pool pool;

        public PoolPipes_Controller()
        {
            display = new Display();
            pool = new Pool(display.V, display.Pipe01, display.Pipe02, display.Hours);
            display.State = pool.StateOfPool();
            display.Pipe01Work = pool.Pipe01Work();
            display.Pipe02Work = pool.Pipe02Work();

            display.DisplayStateOfPool();
        }
    }
}
