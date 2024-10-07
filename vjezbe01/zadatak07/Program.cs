using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Napišite program koji ispisuje je li unešeni broj savršen ili ne.
// Savršen broj je broj koji je jednak zbroju svojih djelitelja (bez njega samoga).

namespace zadatak07
{
    internal class Program
    {

        static void Main(string[] args)
        {
            TernaryDemo();
            Console.Write("Give num: ");
            int n = int.Parse(Console.ReadLine());
            FindPerfectNumber(n);
        }

        private static void FindPerfectNumber(int n)
        {
            // 6, 28, 496 - savrseni brojevi
            Console.WriteLine($"Number {n} is {(IsPerfect(n) ? "perfect" : "not perfect")}");
        }

        private static bool IsPerfect(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n / 2; i++) 
            { 
                if (n % i == 0)
                {
                    suma += i;
                }
            }

            return n == suma;
        }

        private static void TernaryDemo()
        {
            // prvi nacin - if
            int a = 1, b = 2;
            int max;
            if (a == b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            // drugi nacin - ternary operator
            int maxOne = a > b ? a : b;
            Console.WriteLine($"Max one: {maxOne}");

            // ternary - najkrace - odmah u konzolu
            Console.WriteLine($"Max: {(a >= b ? a : b)}");
        }
    }
}
