using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak1.Rjesenje;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrikazProblema();
            Console.WriteLine("\n");
            PrikazRjesenja();
        }

        internal static void PrikazProblema()
        {
            Problem.Margarita pizza1 = new Problem.Margarita();
            pizza1.Priprema();
            pizza1.Pecenje();
            pizza1.Posluzivanje();
            pizza1.Placanje();
            Console.WriteLine($"Uzivam {pizza1.ToString()}\n");

            Problem.Capriccossa pizza2 = new Problem.Capriccossa();
            pizza2.Priprema();
            pizza2.Pecenje();
            pizza2.Posluzivanje();
            pizza1.Placanje();
            Console.WriteLine($"Uzivam {pizza2.ToString()}");
        }

        private static void PrikazRjesenja()
        {
            Rjesenje.Pizza factory = Rjesenje.PizzaFactory.GetPizza("Margarita");
            Console.WriteLine($"Uzivam {factory.ToString()}");
            /*
             dodavanje nove pizze:
            1. napravimo novu klasu za novu pizzu
            2. promjena koda PizzaFactory i dodavanje novog case bloka
            */
            Rjesenje.Pizza vege = Rjesenje.PizzaFactory.GetPizza("Vegeteriana");
            Console.WriteLine($"Uzivam {vege.ToString()}");

            /*
             * dodavanje nove pizze s reflectionom: 
             * 1. kreiram novu klasu
             * 2. to je to
             */
            Rjesenje.Pizza mijesana = Rjesenje.PizzaFactory.GetPizzaByReflection(typeof(Cappriciossa).FullName);
            Console.WriteLine($"Uzivam {vege.ToString()}");
            Pizza slavonska = Rjesenje.PizzaFactory.GetPizzaByReflection(typeof(Slavonska).FullName);
            Console.WriteLine($"Uzivam {slavonska.ToString()}");
        }
    }


}
