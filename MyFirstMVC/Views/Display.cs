using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }

        public double TipSum { set; get; }

        public double TotalSum { get; set; }


        public void Input()
        {
            Console.Write("Vuvedete suma: ");
            double suma=double.Parse(Console.ReadLine());
            this.Amount = suma;
           

            Console.Write("Vuvedi bakshish: ");
            double bakshish=double.Parse(Console.ReadLine());
            this.Percent = bakshish;
          
        }
        public void Output()
        {
            Console.WriteLine($"Bakshisha za servitiora e: {this.TipSum}lv");
            Console.WriteLine($"Sumata za plashtane e: {this.TotalSum}lv");
        }
    }
}
