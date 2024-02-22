using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC2Ex.Model;
using MVC2Ex.View;

namespace MVC2Ex.Controller
{
    public class TransportController
    {
        public Transport transport;
        public Display display;

        public TransportController()
        {
            display = new Display();
            transport = new Transport(display.Kilometers, display.DayOrNight);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
