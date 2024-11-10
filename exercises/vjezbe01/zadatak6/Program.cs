using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial_recursion(4));
            Console.WriteLine(factorial_loop(4));

        }

        private static long factorial_recursion(long n) { 
            if (n <= 0) return 1;
            return factorial_recursion(n - 1) * n;
        }

        private static long factorial_loop(long n)
        {
            long factorial_sum = 1;
            for (long i = n; i > 0; --i )
            {
                factorial_sum *= i;
            }
            return factorial_sum;
        }
    }
}
