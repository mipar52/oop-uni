using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Krug : GeoLik
    {
        public int Radius { get; set; }
        public Krug(string Boja, int radius) : base(Boja)
        {
            Radius = radius;
        }
        public override double Opseg()
        {
            return 2 * Radius *Math.PI;
        }

        public override double Površina()
        {
            return Math.Pow(Radius, 2)*Math.PI;
        }
    }
}
