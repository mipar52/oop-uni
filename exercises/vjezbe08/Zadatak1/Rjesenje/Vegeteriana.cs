using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Rjesenje
{
    internal class Vegeteriana : Pizza
    {
        public override string Sastojci => "Rajcica, Sir, Povrce";

        public override double Cijena { get; set; } = 11.99;
    }
}
