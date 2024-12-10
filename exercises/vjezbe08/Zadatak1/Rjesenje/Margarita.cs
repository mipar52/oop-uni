using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Problem;

namespace Zadatak1.Rjesenje
{
    internal class Margarita : Pizza
    {
        public override string Sastojci => "Rajcica, Sir";
        public override double Cijena { get; set; } = 7.99;
    }
}
