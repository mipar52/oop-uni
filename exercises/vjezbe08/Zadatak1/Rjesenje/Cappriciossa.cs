using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Problem;

namespace Zadatak1.Rjesenje
{
    internal class Cappriciossa : Pizza
    {
        public override string Sastojci => "Sir, Sunka, Gljive";
        public override double Cijena { get; set; } = 9.99;
    }
}
