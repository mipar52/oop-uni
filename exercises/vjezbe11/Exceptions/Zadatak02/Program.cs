using System;

namespace Zadatak02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Avoid();
            ImitateTryParse();
        }

        private static void ImitateTryParse()
        {
            int a;
            do
            {
                Console.Write("Please input a number: ");
            } while(!TryParse(Console.ReadLine(), out a));
        }

        private static bool TryParse(string readLine, out int i)
        {
            try
            {
                i = int.Parse(readLine);
                return true;
            }
            catch (Exception e) when 
                (e is FormatException || 
                 e is OverflowException || 
                 e is ArgumentNullException)
            {
                i = 0;
                return false;
            }
        }

        private static void Avoid()
        {
            string test = null;
            Console.WriteLine(test?.ToLower()?[0]);
        }
    }
}