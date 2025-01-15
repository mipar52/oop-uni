using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PredicateDemo();
            ConverterDemo();
            ComparionDemo();
        }

        private static void PredicateDemo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- PREDICATE -----");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine("Pozitivni brojevi: ");
            Predicate<int> pozitivniBroj = PozitivniBroj;
            List<int> list = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++) 
            { 
               int broj = random.Next(-10, 10);
                Console.WriteLine(pozitivniBroj(broj) ? $"{broj} je pozitivan" : $"{broj} je negativan" );
                list.Add(broj);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nPrvi pozitivni broj je: {list.Find(pozitivniBroj)}");
            Console.WriteLine($"Prvi parni broj je {list.Find(n => n % 2 == 0)}");
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nSTRING: ");
            Predicate<string> isNeitherNullOrEmpty = s => s != null && s.Trim().Length != 0;
            string test = "Ana";
            Console.WriteLine(isNeitherNullOrEmpty(test) ? "Nije prazan ni null" : "Prazan string ili null");
            test = " ";
            Console.WriteLine(isNeitherNullOrEmpty(test) ? "Nije prazan ni null" : "Prazan string ili null");
        }
        private static bool PozitivniBroj(int n) => n > 0;

        private static void ConverterDemo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- CONVERTER -----");
            string number = "2";
            Converter<string, int> stringToInt = int.Parse;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(stringToInt(number));

            Converter<double, double> celsiusToKelvin = c => c + 273.15;
            double temp = -1;
            Console.WriteLine($"{temp} oC = {celsiusToKelvin(temp)} K");
        }

        private static void ComparionDemo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- COMPARISON -----");

            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Title = "Sliders" },
                new Product { Id = 2, Title = "Shoes" },
                new Product { Id = 3, Title = "Skateboard" }
            };

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ID Asc: ");
            Comparison<Product> idAsc = (a,b) => a.Id.CompareTo(b.Id);
            products.Sort(idAsc);
            products.ForEach(Console.WriteLine);
            
            Console.WriteLine("\nTitle Desc: ");
            products.Sort((a,b) => -a.Title.CompareTo(b.Title));
            products.ForEach(Console.WriteLine);

        }

        private class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public override string ToString()
            {
                return $"{Id} - {Title}";
            }
        }

    }
}
