using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Problem
{
    internal class Capriccossa
    {
        public string Sastojci { get; } = "Rajcica, Sir, Gljive";
        public double Cijena { get; set; } = 9.99;
        public void PripremaPizze() => Console.WriteLine($"Priprema Margarite...");
        // svaki objekt ima GetType() metodu koja vraca Type
        // GetType() -> Assembly name, namespace, class name
        // primjer -> GetType().Assebmly - ime assembly, .Namespace - name namespacea, .Name -> ime klase, .FullName() -> namespace + ime klase
        public void Priprema() => Console.WriteLine($"Priprema {this.GetType().Name}");
        public void Pecenje() => Console.WriteLine($"Pecenje {this.GetType().Name}");
        public void Posluzivanje() => Console.WriteLine($"Posluzivanje {this.GetType().Name}");
        public void Placanje() => Console.WriteLine($"Placanje {this.GetType().Name}, {this.Cijena}");
        public override string ToString() => $"{this.GetType().Name}: {this.Sastojci}. Cijena: {this.Cijena}";
    }
}
