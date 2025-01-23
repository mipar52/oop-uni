using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            try
            {
                Console.WriteLine(CheckNumber(numbers[0]) ? "YES" : "NO");
            }
            catch (Exception e)
            {
                if (e is IndexOutOfRangeException)
                {
                    Console.WriteLine(e.Message);
                } else if (e is MegaException)
                {
                    Console.WriteLine("MEGAAA: " + e.Message);
                }
            }
        }

        public static bool CheckNumber(int number)
        {
            if (number >= 1)
            {
                throw new MegaException("MEGAAAA");
            } 
            return true;
        }
    }
}