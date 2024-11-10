using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Lightbulb: ISwitchable
    {
        public int Lenght { get; set; }
        public int Power { get; set; }

        public void SwitchOff()
        {
            Console.WriteLine("Lighbulb off!");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Lighbulb on!");
        }

        public override string ToString() 
            => $"Duljina zarne niti: {this.Lenght.Format("mm")}\nSnaga: {this.Power.Format("W")}";


    }
}
