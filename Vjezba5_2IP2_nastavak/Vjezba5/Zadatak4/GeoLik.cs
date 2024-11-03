using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal abstract class GeoLik
    {
        public string Boja {  get; set; }
        
        public GeoLik(string Boja) => this.Boja = Boja;

        public abstract double Opseg();
        public abstract double Površina();
    }
}
