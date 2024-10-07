using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Napišite program koji traži unos godine i ispisuje je li ta godina
// prijestupna ili ne. Godina je prijestupna ako je djeljiva sa 4, nije
// djeljiva sa 100, osim ako je djeljiva sa 400.
namespace zadatak04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            //if+tab+tab
            if (year % 4 == 0) 
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine("Year is leap year!");
                } else
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("Year is leap year!");
                    } else
                    {
                        Console.WriteLine("Year is not leap year!");
                    }
                }
            } else
            {
                Console.WriteLine("Year is not leap year!");
            }

            // kraci solution
            if (year % 4 == 0 && year % 100 == 0 || year % 400 == 0)
            {
                Console.WriteLine("Year is leap");
            }
            else Console.WriteLine("Year is not leap year!");
        }
    }
}
