using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Rjesenje
{
    internal class Slavonska : Pizza
    {
        public override string Sastojci => "Rajcica, Sir, Sunka, Feferoni, Spek, Vrhnje";

        public override double Cijena { get; set; } = 6.99;
    }
}
