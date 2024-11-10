using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Stove:ISwitchable
    {
        public string Producer {  get; set; }

        //enumi
        public enum StoveType { Plin, Struja, Kombinirano }
        public StoveType Type { get; set; }
        public override string ToString()
        {
            return $"Proizvodac: {Producer}\nTip: {Type}";
        }

        public void SwitchOn()
        {
            Console.WriteLine("Stove on!");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Stove off!");
        }
    }
}
