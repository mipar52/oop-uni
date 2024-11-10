using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Trokut: GeoLik
    {
        public int A {  get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Trokut(string Boja, int A, int B, int C) : base(Boja) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public override double Opseg() => A + B + C;
        public override double Površina()
        {
            double s = Opseg() / 2;
            return s * 2; //random
        }
    }
}
