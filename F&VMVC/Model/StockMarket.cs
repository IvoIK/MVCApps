using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_VMVC.Model
{
    public class StockMarket
    {
        private double fruitsPrice;
        private double vegetablesPrice;
        private int fruitsKilo;
        private int vegetablesKilo;

        public StockMarket(double fruitsPrice, double vegetablesPrice, 
        int fruitsKilo, int vegetablesKilo)
        {
            this.FruitsPrice = fruitsPrice;
            this.VegetablesPrice = vegetablesPrice;
            this.FruitsKilo = fruitsKilo;
            this.VegetablesKilo = vegetablesKilo;
        }

        public StockMarket() : this(0,0,0,0) { } 

        public double FruitsPrice
        {
            get { return fruitsPrice; }
            set 
            { 
                if (fruitsPrice < 0.00 && fruitsPrice > 1000.00)
                {
                    throw new ArgumentException("Invalid fruits price!");
                }
                fruitsPrice = value; 
            }
        }

        public double VegetablesPrice
        {
            get { return vegetablesPrice; }
            set 
            {
                if (vegetablesPrice < 0.00 && vegetablesPrice > 1000.00)
                {
                    throw new ArgumentException("Invalid vegetables price!");
                }
                vegetablesPrice = value; 
            }
        }

        public int FruitsKilo
        {
            get { return fruitsKilo; }
            set 
            {
                if (fruitsKilo < 0 && fruitsKilo > 1000)
                {
                    throw new ArgumentException("Invalid fruits kilogram!");
                }
                fruitsKilo = value; 
            }
        }

        public int VegetablesKilo
        {
            get { return vegetablesKilo; }
            set 
            {
                if (vegetablesKilo < 0 && vegetablesKilo > 1000)
                {
                    throw new ArgumentException("Invalid vegetables kilogram!");
                }
                vegetablesKilo = value; 
            }
        }

        public double CalculateVegetablesPrice()
        {
            return vegetablesPrice * vegetablesKilo;
        }

        public double CalculateFruitsPrice()
        {
            return fruitsPrice * fruitsKilo;
        }

        public double CalculateTotalPrice()
        {
            return (CalculateFruitsPrice() + CalculateVegetablesPrice()) / 1.94;
        }
    }
}