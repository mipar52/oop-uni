using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ispišite sve proste brojeve iz intervala [1, 100].
namespace zadatak08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPrimeNumbersInRange(1, 100);
        }

        private static void PrintPrimeNumbersInRange(int from, int to)
        {
            for (int i = from; i <= to; i++) 
            { 
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine($"Number {i} is a prime number!");
                }
            }
        }

        private static bool IsPrimeNumber(int i)
        {
            for (int j = 2; j < i / 2; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return i != 1;
        }
    }

}
