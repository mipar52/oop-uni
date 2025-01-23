using System;
using System.Collections.Generic;
using System.Linq;

namespace zadatak01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // LINQ -> chainanje operator -> map, filter, reduce
            var zupanije = DohvatiZupancije();
            
            // nazivi svih zupanija
            zupanije
                .Select(x => x.Naziv) // selectaj sve nazive -> select vraca IEnumarable
                .ToList() //kolekcija stringa
                .ForEach(x => Console.WriteLine(x)); // ispisi svaki string
            
            Console.WriteLine();
            // koje imaju vise od 2 grada
            zupanije
                .Where(x => x.gradovi.Count > 2) // uvjet za gradove
                .Select(x => x.Naziv) // selectaj sve nazive
                .ToList() //kolekcija stringa
                .ForEach(x => Console.WriteLine(x)); // ispisi svaki string
            
            Console.WriteLine();
            // ukupno stanovika u ST-DALM
            Console.WriteLine(
            zupanije
                .Where(x => x.Naziv == "ST-DALM") // uvjet za zupaniju
                .Select(x => x.gradovi.Sum(g => g.Stanovnici)) // uzmi gradove i zbroji sum
                .Single()); // ako kolekcija ima 1 element, vrati njega. Ako ima 0 ili 2 ili vise, baci exception
            
            Console.WriteLine();
            // naziv i stanovnistvo druge i trece najvece po broju stanovika
            zupanije
                .OrderByDescending(z => z.gradovi.Sum(g => g.Stanovnici)) // od najvece
                .Skip(1) // izbaci najvecu
                .Take(2) // drugu i trecu
                .Select(z => new { Ime = z.Naziv, Broj = z.gradovi.Sum(g => g.Stanovnici)}) // stvori nove objekte s nazivom i sumom
                .ToList()
                .ForEach(z => Console.WriteLine($"{z.Ime} - {z.Broj}")); // uzmi nove objekte i ispisi ih
            
            // prikaz svih gradova i broj stanovnika, po broju stanovika silazno
            Console.WriteLine();
            zupanije
                .SelectMany(z => z.gradovi) // list flatening -> iz liste lista u listu
                .OrderByDescending(x => x.Stanovnici)
                .ToList()
                .ForEach(z => Console.WriteLine($"{z.Name} - {z.Stanovnici}"));
        }
        
        private static List<Zupanija> DohvatiZupancije()
        {
            Zupanija zg = new Zupanija(1, "Zagrebacka");
            Zupanija md = new Zupanija(2, "Medimurska");
            Zupanija st = new Zupanija(3, "ST-DALM");
            Zupanija ri = new Zupanija(4, "Rijecka");
        
            zg.gradovi = new List<Grad>
            {
                new Grad("Zagreb", 10000),
                new Grad("Varazdin", 4343),
                new Grad("NEsto", 10433000),
                new Grad("Haha", 098548),
            };
        
            md.gradovi = new List<Grad>
            {
                new Grad("Kakanj", 10000),
                new Grad("Bibinje", 4343),
            };
        
            st.gradovi = new List<Grad>
            {
                new Grad("split", 10000),
                new Grad("makarska", 4343),
                new Grad("cakovec", 10433000),
                new Grad("trogir", 098548),
            };
        
            ri.gradovi = new List<Grad>
            {
                new Grad("fdfdga", 10000),
                new Grad("Bibisgsagnje", 4343),
                new Grad("rekrererere", 10433000),
            };
            return new List<Zupanija> { zg, md, st, ri };
        }
    }
}