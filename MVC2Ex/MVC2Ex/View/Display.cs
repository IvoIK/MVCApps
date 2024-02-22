using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC2Ex.View
{
    public class Display
    {
        public int Kilometers {  get; set; }
        public string DayOrNight { get; set; }
        public double TotalPrice { get; set; }

        public Display()
        {
            Kilometers = 0;
            DayOrNight = string.Empty;
            TotalPrice = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter kilometers: ");
            Kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter when time you will travel: ");
            DayOrNight = Console.ReadLine();
        }

        public void ShowPrice()
        {
            Console.WriteLine($"Your cheapest price is {TotalPrice:f2}");
        }
    }
}