using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. Napišite program koji ispisuje sumu prvih 100 prirodnih brojeva.
namespace zadatak05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stvaranje metod - alt + enter za generiranje
            WhileDemo();
            ForDemo();
            DoWhileDemo();
        }

        private static void WhileDemo()
        {
            int i = 0, suma = 0;
            // while + tab + tab
            while (i <= 100) {
              //  suma += i;
              //  i++;

              // ili jednostavnije
              suma += i++; // prvo zbrajanje pa onda inkrement i
              //  suma += ++i; // prvo inkrement i pa zbrajanje
            }
            Console.WriteLine($"While: Suma prvih {--i} brojeva je {suma}");
        }
        private static void ForDemo()
        {
            // While i for petlja su iste
            int i = 0, suma = 0;

            for (; i <= 100; i++) {
                suma += i;
            }
            Console.WriteLine($"For: Suma prvih {--i} brojeva je {suma}");
        }
        private static void DoWhileDemo()
        {
            int i = 0, suma = 0;
            do
            {
                suma += i++;
            } while (i <= 100);

            Console.WriteLine($"Do-while: Suma prvih {--i} brojeva je {suma}");
        }
    }
}
