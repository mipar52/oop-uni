using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ime = ReadString("Unesite ime ucenika: ");
            string prezime = ReadString("Unesite prezime ucenika: ");

            int n = ReadInt("Unesite broj ocjena: ");
            int[] ocjene = new int[n];

            InsertGrades(ocjene);
            PrintScore(ime, prezime, ocjene);
        }

        private static string ReadString(string message)
        {
            string s;
            do
            {
                Console.Write(message);
                s = Console.ReadLine().Trim();
                //} while (s.Length == 0);
            } while (string.IsNullOrWhiteSpace(s));

            return s;
        }

        private static int ReadInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out n)); // out je zapravo result
            return n;
        }

        private static void InsertGrades(int[] ocjene)
        {
            for (int i = 0; i < ocjene.Length; i++) 
            {
                
                ocjene[i] = ReadIntInRage($"Unesite {i+1}. ocjenu: ", 1, 5); 
            }
        }

        private static int ReadIntInRage(string message, int min, int max)
        {
            int n;
            do
            {
                n = ReadInt(message);
            } while (n < min || n > max);
            return n;
        }

        private static void PrintScore(string ime, string prezime, int[] ocjene)
        {
            double sum = 0;
            //for each - namjenjena za liste
            foreach (var ocjena in ocjene) 
            { 
               if (ocjena == 1)
                {
                    Console.WriteLine("Učenik je nedovoljan!");
                }

               sum += ocjena;
            }
            Console.WriteLine($"Prosjek ocjena ucenika {ime} {prezime} je {sum / ocjene.Length}");
        }
    }
}
