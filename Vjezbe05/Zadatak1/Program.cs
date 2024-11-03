using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber
            {
                RealniDio = 3,
                ImaginarniDio = 4
            };
            Console.WriteLine(c1.ToString());

            ComplexNumber c2 = new ComplexNumber
            {
                RealniDio = 3,
                ImaginarniDio = 4
            };

            Console.WriteLine(c1 == c2);
            // cn1 = cn2 => cn1 se referira na cn2, ukoliko su uvjeti istiniti onda je sve bez izmjene
            Console.WriteLine(c1.Equals(c2));
            // Equals isto uspoređuje reference - i njega smo overrideali
        }
    }
}
