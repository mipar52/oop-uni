using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Cannot create an instance of the abstract class or interface 'interface'
            //  You cannot create an instance of an abstract class or an interface. For more information, see Interfaces.

            //GeoLik geoLik = new GeoLik();

            GeoLik pravokutnik = new Pravokutnik("plava", 5, 10);
            GeoLik krug = new Krug("crvena", 3);

            List<GeoLik> figure = new List<GeoLik> { krug, pravokutnik };

            foreach (GeoLik geolik in figure) 
            {
                Console.WriteLine($"Povrsina od {geolik} je {geolik.Površina()}");
                Console.Write($"Opseg od {geolik.GetType()} je {geolik.Opseg()}");
                Console.WriteLine();
            }

            // skracivanje pomocu lamdbe
            figure.ToList().ForEach( geolik =>
            {
                Console.WriteLine($"Povrsina od {geolik} je {geolik.Površina()}");
                Console.Write($"Opseg od {geolik.GetType()} je {geolik.Opseg()}");
                Console.WriteLine();
            });

        }
    }
}
