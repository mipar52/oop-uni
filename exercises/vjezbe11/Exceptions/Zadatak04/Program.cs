using System;

namespace Zadatak04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(10 / 0.0); // baca infinity
            Console.WriteLine(0 / 0.0); // baca NaN (not a number)
            
            double num = 10;
            double den = 0;
            try
            {
                double q = Divice(num, den);
                Console.WriteLine(q);
            }
            catch (DivideByDoubleZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
        //Caller
        /// <summary>
        /// Divides by num with den
        /// </summary>
        /// <param name="num"></param>
        /// <param name="den"></param>
        /// <returns> num / den </returns>
        /// <exception cref="DivideByDoubleZeroException"></exception>
        private static double Divice(double num, double den)
        {
            if (den == 0)
            {
                throw new DivideByDoubleZeroException();
            }
            return num / den;
        }
    }
}