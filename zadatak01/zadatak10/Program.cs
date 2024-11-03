using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Napišite program koji za uneseni broj n učitava n brojeva i
// ispisuje onog koji ima najveći zbroj znamenaka.

namespace zadatak10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            FillNumbers(numbers);
            PrintMaxSumDigits(numbers);
        }

        private static void FillNumbers(int[] numbers)
        {
            // lista je objekt koji ima svoja stvojstva -> .Lenght

            for (int i = 0; i < numbers.Length; i++)
            {
                // svi brojevi u listi u 0 po defaultu
                // Console.WriteLine(numbers[i]);

                Console.Write($"Insert {i + 1} number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void PrintMaxSumDigits(int[] numbers)
        {
            int index = 0;
            int maxSum = SumOfDigits(numbers[0]);

            for (int i = 1; i < numbers.Length; i++) 
            {
                int sum = SumOfDigits(numbers[i]);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            }
            Console.WriteLine($"Number with highest sum is {numbers[index]}, with sum {maxSum}");
        }

        private static int SumOfDigits(int value) 
        {
            int sum = 0;
            while (value > 0) 
            {
                sum += value % 10;
                value /= 10;
            }
            return sum;
        }
    }
}
