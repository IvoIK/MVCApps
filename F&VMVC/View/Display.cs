using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_VMVC.View
{
    public class Display
    {
        public double VegetablesPrice {  get; set; }
        public double FruitsPrice { get; set; }
        public double TotalPrice { get; set; }
        public int FruitsKilo {  get; set; }
        public int VegetablesKilo { get; set; }

        public Display() 
        {
            VegetablesKilo = 0;
            VegetablesPrice = 0;
            FruitsKilo = 0;
            VegetablesPrice = 0;
            TotalPrice = 0;
            GetValues();
        }

        private void GetValues()
        {
            Console.WriteLine("Enter fruits price: ");
            FruitsPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter vegetable price: ");
            VegetablesPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter fruits kilo: ");
            FruitsKilo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter vegetable kilo: ");
            VegetablesKilo = int.Parse(Console.ReadLine());
        }

        public void ShowTotalPrice()
        {
            Console.WriteLine($"The total price is: {TotalPrice}");
        }
    }
}