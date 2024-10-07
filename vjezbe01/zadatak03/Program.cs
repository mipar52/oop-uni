using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Napišite program kalkulator sa osnovnim računskim operacijama.
// Program traži unos 2 cijela broja, a zatim unos računske operacije.
// Nakon toga ispisuje rezultat i omogućuje korisniku ponovno
// računanje ili prekid programa. Program treba lijepo ispisivati sve
// poruke za korisnika.

namespace zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // varijable provjere
            char repeat;
            do
            {
                Console.Clear(); // ocisti konzolu
                Console.Write("Give first num: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Give second num: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Give math operation (+, -, *, /): ");
                string operation = Console.ReadLine();

                //switch naredba -> sw+tab+tab
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;

                    default:
                        Console.WriteLine("Wrong operation!");
                        break;
                }

                Console.Write("Repeat (y/n): ");
                //  repeat = char.Parse(Console.ReadLine());
                // baca gresku ako nismo unijeli char ili imamo vise od jednog znaka

                // repeat = Console.ReadLine()[0];
                // baca gresku ako nema znaka ili ako se samo enter pritisne

                // repeat = (char)Console.Read(); - cita samo prvi znak ovaj Read()
                // ostavlja \n koji  naredba Console.Read() ne brise
                // Console.ReadLine() mice \n

                repeat = Console.ReadKey().KeyChar;
            } while (repeat == 'y');
        }
    }
}
