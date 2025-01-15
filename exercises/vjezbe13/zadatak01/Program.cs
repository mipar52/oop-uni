using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak01
{
    internal class Program
    {
        private const char del = ',';
        public static void Main(string[] args)
        {
            ISet<int> a;
            do
            {
                Console.WriteLine("Insert elements from a: ");
                
            } while(!TryParse(Console.ReadLine(), out a));
            
            ISet<int> b;
            do
            {
                Console.WriteLine("Insert elements from b: ");
                
            } while(!TryParse(Console.ReadLine(), out b));
            
           IEnumerable<int> union = a.Union(b);
           PrintElements("A union B = ",union);
           PrintElements("A intersect B = ",a.Intersect(b));
           PrintElements("A except B = ",a.Except(b));
           Console.WriteLine(a.IsSubsetOf(b) ? "A is subset of B" : "A is not subset of B");

        }

        
        private static void PrintElements(string messafe, IEnumerable<int> elements)
        {
            string x = string.Join(del.ToString(), elements);
            Console.WriteLine($"{messafe} {{{x}}}");
        }

        // out -> init set
        private static bool TryParse(string readLine, out ISet<int> ints)
        {
            ints = new HashSet<int>();
            string[] elements = readLine.Split(del);
            foreach (string element in elements)
            {
                try
                {
                    if (!ints.Add(int.Parse(element)))
                    {
                        Console.WriteLine($"Duplicate element: {element}");
                        return false;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Invalid format: {e.Message}");
                    return false;
                }
            }
            return true;
        }

        private static void DictionaryPractice()
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            dict.Add(5, "five");

            for (int i = 0; i < dict.Count; i++)
            {
                if (dict.ContainsKey(i))
                {
                    Console.WriteLine($"{dict[i]}");
                }

                if (dict.TryGetValue(i, out string value))
                {
                    Console.WriteLine($"{value}");
                }
            }
        }
    }
}