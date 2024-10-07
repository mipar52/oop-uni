using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Napišite program koji traži unos 2 cijela broja i prikazuje na ekranu njihov umnožak i kvocijent
namespace zadatak02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number: ");
            int a = int.Parse(Console.ReadLine()); // C# ovo je parsanje, drugacije od castanja
            
            // ctrl + d -> duplikacija koda
            Console.Write("Write second number: ");
            int b = int.Parse(Console.ReadLine());

            // ne radi kad se stavi a + b bez zagrada, tretira se kao string
            Console.WriteLine(a + " + " + b + " = " + a + b);
            // sad radi
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " + " + b + " = " + (a - b));

            // mnozenje i dijeljenje
            Console.WriteLine(a + " + " + b + " = " + a * b);
            Console.WriteLine(a + " + " + b + " = " + a / b);

            // bolji nacin ispisa
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            //postoji li bolji nacin
            //interpolacija stringa
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
    }
}
