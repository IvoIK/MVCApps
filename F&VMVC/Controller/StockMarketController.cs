using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using F_VMVC.Model;
using F_VMVC.View;

namespace F_VMVC.Controller
{
    public class StockMarketController
    {
        private Display display;
        private StockMarket stockMarket;

        public StockMarketController()
        {
            display = new Display();
            stockMarket = new StockMarket(display.FruitsPrice, display.VegetablesPrice, display.FruitsKilo, display.VegetablesKilo);
            display.TotalPrice = stockMarket.CalculateTotalPrice();
            display.ShowTotalPrice();
        }
    }
}