using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ispišite sve Armstrongove brojeve iz intervala [1, 10000].
// Broj je Armstrongov ako je jednak zbroju kubova svojih znamenaka.

namespace zadatak09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintArmstringsInRange(1, 10000);
        }

        private static void PrintArmstringsInRange(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                if (IsArmstrongNumber(i))
                {
                    Console.WriteLine($"Number {i} is an Armstrong number!");
                }
            }
        }

        private static bool IsArmstrongNumber(int i)
        {
            int sum = 0, copy = i;

            while (copy > 0) 
            {
                sum += (int)Math.Pow(copy % 10, 3);
                copy /= 10;
            }

            return sum == i;
        }
    }
}
