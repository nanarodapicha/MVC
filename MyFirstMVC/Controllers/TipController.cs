using MyFirstMVC.Models;
using MyFirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class TipController
    {

        Display display = new Display();
        Tip mytip = new Tip();
        public TipController()
        {
            display.Input();
            mytip.Amount = display.Amount;
            mytip.Percent = display.Percent;
            mytip.CalculateTip();
            mytip.CalculateTotal();
            display.TipSum = mytip.CalculateTip();
            display.TotalSum = mytip.CalculateTotal();
            display.Output();

        }
    }
}
