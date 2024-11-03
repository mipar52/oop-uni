using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Truck: Car
    {
        public int Lenght { get; set; }

        public Truck(int number, string type, double acceleration, int lenght): base(number, type, acceleration) 
        {
            this.Lenght = lenght;
        }

        public override void Drive()
        {
            Console.WriteLine("Truck driving...");
        }

        public override void Stop()
        {
            Console.WriteLine("Truck stopping...");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Lenght: {this.Lenght}";
        }
    }
}
