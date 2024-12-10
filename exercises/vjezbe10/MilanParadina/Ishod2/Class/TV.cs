using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod2.Class
{
    internal class TV : Device
    {
        public TV(string manufacturer, string model, string color) : base(manufacturer, model, color)
        {
            Console.WriteLine("Created new television!");
        }

        public override string ToString() => $"TV info: {base.ToString()}\n";

        public override void TurnOff()
        {
            Console.WriteLine("TV on!");
        }

        public override void TurnOn()
        {
            Console.WriteLine("TV off!");
        }
    }
}
