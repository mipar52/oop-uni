using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Pravokutnik : GeoLik
    {
        public int A {  get; set; }
        public int B { get; set; }
        public Pravokutnik(string Boja, int a, int b) : base(Boja)
        {
            A = a;
            B = b;
        }
        public override double Opseg() => 2 * (A + B);
        public override double Površina() => A * B;
    }
}
