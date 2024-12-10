using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Rjesenje
{
    abstract class Pizza
    {
        public abstract string Sastojci {  get; }
        public abstract double Cijena { get; set; }
        public void Priprema() => Console.WriteLine($"Priprema {this.GetType().Name}");
        public void Pecenje() => Console.WriteLine($"Pecenje {this.GetType().Name}");
        public void Posluzivanje() => Console.WriteLine($"Posluzivanje {this.GetType().Name}");
        public void Placanje() => Console.WriteLine($"Placanje {this.GetType().Name}, {this.Cijena}");
        public override string ToString() => $"{this.GetType().Name}: {this.Sastojci}. Cijena: {this.Cijena}\n";

    }
}
