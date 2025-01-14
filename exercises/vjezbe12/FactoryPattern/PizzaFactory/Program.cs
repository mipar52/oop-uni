using System;
using PizzaFactory.Problem;
using PizzaFactory.Solution;
using Margarita = PizzaFactory.Problem.Margarita;

namespace PizzaFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        //    ShowProblem();
            ShowSolution();
        }

        private static void ShowSolution()
        {
            Pizza margharita = PizzaMakerFactory.GetPizza("Margarita");
            Console.WriteLine($"Consuming: {margharita}");
            Pizza vegeteriana = PizzaMakerFactory.GetPizzaButBetter(typeof(Solution.Vegetirana).FullName);
            Console.WriteLine($"Consuming: {vegeteriana}");
            
        }

        private static void ShowProblem()
        {
            Margarita margarita = new Margarita();
            margarita.Prepare();
            margarita.Bake();
            margarita.Serve();
            margarita.Charge();
            Console.WriteLine(margarita.ToString());     
            
            Cappriciosa cappriciosa = new Cappriciosa();
            cappriciosa.Prepare();
            cappriciosa.Bake();
            cappriciosa.Serve();
            cappriciosa.Charge();
            Console.WriteLine(cappriciosa.ToString()); 
        }
    }
}