using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1.Rjesenje
{
    internal class PizzaFactory
    {
        internal static Pizza GetPizza(string name)
        {
            Pizza pizza;
            switch (name)
            {
                case "Margarita":
                    pizza = new Margarita();
                    break;
                case "Cappriciossa":
                    pizza = new Cappriciossa();
                    break;
                case "Vegeteriana":
                    pizza = new Vegeteriana();
                    break;
                default:
                    throw new Exception("Ne postoji ta pizza!");
            }

            pizza.Priprema();
            pizza.Pecenje();
            pizza.Posluzivanje();
            pizza.Placanje();
            return pizza;
        }

        internal static Pizza GetPizzaByReflection(string name) 
        {
            Pizza pizza = GetPizzaByClassName(name);

            pizza.Priprema();
            pizza.Pecenje();
            pizza.Posluzivanje();
            pizza.Placanje();

            return pizza;
        }

        private static Pizza GetPizzaByClassName(string name)
        {
            Type type = Type.GetType(name);
            return Activator.CreateInstance(type) as Pizza;
        }
    }
}
