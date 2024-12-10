using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryCatch();
            TryCatchFinally();
        }

        private static void TryCatch()
        {
            // shortcut -> ctrl + k + s
            try
            {
                int index = 10;
                index = index / 0;
                Console.WriteLine(index); // ovaj dio koda se nece izvrsiti
            }
            catch (DivideByZeroException ex)
            { 
                Console.WriteLine($"Type: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine($"Message: {ex.Message}");

            }
            Console.WriteLine("Nastavak izvrsavanja...");
        }

        private static void TryMultipleCatch()
        {
            // shortcut -> ctrl + k + s
            try
            {
                int index = 10;
                index = index / 0;
                Console.WriteLine(index); // ovaj dio koda se nece izvrsiti
                int.Parse("milica");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Type: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Type: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Type: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine($"Message: {ex.Message}");

            }
            catch (Exception) {}//isto kao da smo napisali samo catch bez exceptiona 
            Console.WriteLine("Nastavak izvrsavanja...");
        }


        private static void TryCatchFinally()
        {
            // shortcut -> ctrl + k + s
            try
            {
                int index = 10;
                index = index / 0;
                Console.WriteLine(index); // ovaj dio koda se nece izvrsiti
            }
            catch (DivideByZeroException ex) { Console.WriteLine("Dijeljenje s nulom!! " + ex.Message); }
            finally
            {
                // ovaj se blok izvrsavanja bez obzira je li se catch triggerao ili ne
                // 
                Console.WriteLine("Finally blok...");

            }
        }
    }
}
