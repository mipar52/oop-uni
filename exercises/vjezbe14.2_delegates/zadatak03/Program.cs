using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace zadatak03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Predicates();
            Converters();
            Comparisons();
        }
        private static bool Positive(int n) => n >= 0;
    
        private static void Comparisons()
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Apple", Price = 10 },
                new Product { Name = "Banana", Price = 20 },
                new Product { Name = "Orange", Price = 30 },
            };
            Comparison<Product> comparison = (a, b) => a.Name.CompareTo(b.Name);
            products.Sort(comparison);
            products.ForEach(Console.WriteLine);
        }

        private class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        private static void Converters()
        {
            Converter<string, int> f = int.Parse; // uvijek uzima jedan i vraca jedan
            Console.WriteLine(f("99"));
            Converter<double, double> ctoKel = c => c + 273.15;
            Console.WriteLine(ctoKel(15.3));

        }

        private static void Predicates()
        {
            Predicate<int> predicate = Positive; // vraca bool, prima jedan
            Console.WriteLine(predicate(-1));
            Console.WriteLine(predicate(0));
            Console.WriteLine(predicate(1));
            
            List<int> myList = new List<int> { 99, -104, -3, 2 };
            Console.WriteLine(myList.Find(predicate));
            Console.WriteLine(myList.Find(n => n % 2 == 0 && n >= 0));
        }
    }
}