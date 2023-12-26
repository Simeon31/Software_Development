using System;
using System.Collections.Generic;
using System.Text;
using MVC_Applications.Model;
using MVC_Applications.Views;

namespace MVC_Applications.Controllers
{
    class Transport_Price_Controller
    {
        TransportPrice transportPrice;
        Display display;

        public Transport_Price_Controller()
        {
            display = new Display();
            transportPrice = new TransportPrice(display.Distance, display.DayTime);
            display.TotalPrice = transportPrice.CalculateLowestTransportPrice();
            display.PrintPrice();
        }
    }
}
