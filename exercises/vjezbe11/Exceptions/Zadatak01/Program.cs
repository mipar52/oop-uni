using System;

namespace Zadatak01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Demo();
        }

        private static void Demo()
        {
            try
            {
                int n = 0;
                int index = 10 / n;
                Console.WriteLine("This code will not be reached!");
                int[] array = { 1, 3, 4 };
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Handeled exception! {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Handeled exception! {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("This code will always be reached!");
            }
            Console.WriteLine("This code will be reached!");
        }
    }
}