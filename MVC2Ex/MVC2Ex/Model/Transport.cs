using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MVC2Ex.Model
{
    public class Transport
    {
        private int kilometers;
        private string dayOrNight;

        public Transport(int kilometers, string dayOrNight)
        {
            this.Kilometers = kilometers;
            this.DayOrNight = dayOrNight;
        }

        public Transport() : this(0, "") { }

        public int Kilometers
        {
            get { return this.kilometers; }
            set { this.kilometers = value;}
        }

        public string DayOrNight
        {
            get { return this.dayOrNight; }
            set { this.dayOrNight = value; }
        }

        public double CalculatePrice()
        {
            double price = 0;
            if (kilometers < 20)
            {
                price = 0.7;
                if (dayOrNight == "day")
                {
                    price = (price + (kilometers * 0.79));
                }
                else if (dayOrNight == "night")
                {
                    price = (price + (kilometers * 0.9));
                }
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                price = (kilometers * 0.09);
            }
            else
            {
                price = (kilometers * 0.06);
            }
            return price;
        }
    }
}
