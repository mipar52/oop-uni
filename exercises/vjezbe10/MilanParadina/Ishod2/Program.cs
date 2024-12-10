using Ishod2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV("Samsung", "Q80B-OLED", "blue");
            Console.WriteLine(tv.ToString());
            tv.TurnOn();
            tv.TurnOff();

            Projector projector = new Projector("LG", "Proj-HD", "Red", "1440x860");
            Console.WriteLine(projector.ToString());
            projector.TurnOn();
            projector.TurnOff();
        }
    }
}
