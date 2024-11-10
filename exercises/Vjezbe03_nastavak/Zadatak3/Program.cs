using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // baci exception -> Razlomak r1 = new Razlomak(2, 0);
            ParsiranjeRacunanje();

            /*
             * 
             * char dalje;
            do
            {
                Console.WriteLine("Unesite brojnik prvog razlomka: ");
                string v = Console.ReadLine();
                double brojnik = double(v);
                Console.WriteLine("Unesite nazivnik prvog razlomka: ");
                double nazivnik = v;

                Razlomak razlomak = new Razlomak(brojnik, nazivnik);
                Console.WriteLine("Odlicno, hvala lijepa!");

                Console.WriteLine("Unesite brojnik drugog razlomka: ");
                brojnik = v;
                Console.WriteLine("Unesite nazivnik drugog razlomka: ");
                nazivnik = v;

                Razlomak razlomak2 = new Razlomak(brojnik, nazivnik);

                Console.WriteLine("Dajte mat. operaciju (+, -, *, /)");
                char operacija = v[0];

                Console.WriteLine("Rezultat je: ");
                switch operacija {
                    case '+':
                        Console.WriteLine($"{razlomak.Rezutat() + razlomak2.Rezutat()}");
                        break;
                    case '-':
                        Console.WriteLine($"{razlomak.Rezutat() - razlomak2.Rezutat()}");
                        break;
                    case '*':
                        Console.WriteLine($"{razlomak.Rezutat() * razlomak2.Rezutat()}");
                        break;
                    case '/':
                        Console.WriteLine($"{razlomak.Rezutat() / razlomak2.Rezutat()}");
                        break;
                    default:
                        Console.WriteLine("neispravna radnja!");
                        break;

                }

                Console.WriteLine("Dalje (d/n): ");
                v = Console.ReadLine();
                dalje = v[0];
            } while (dalje == 'd');
             * 
             */


        }

        private static void ParsiranjeRacunanje()
        {
            Console.WriteLine("Unesite prvi razlomak: ");
            string razlomka1String = Console.ReadLine();
            Console.WriteLine("Unesite drugi razlomak: ");
            string razlomka2String = Console.ReadLine();

            Razlomak razlomak1 = Razlomak.Parse(razlomka1String);
            Razlomak razlomak2 = Razlomak.Parse(razlomka2String);

            Console.WriteLine(razlomak1.Zbrajanje(razlomak2));

        }
    }
}
