using System;

namespace PizzaFactory.Solution
{
    static class PizzaMakerFactory
    {
        public static Pizza GetPizza(string name)
        {
            Pizza pizza;
            switch (name)
            {
                case "Margarita":
                    pizza = new Margarita();
                    break;
                case "Capricious":
                    pizza = new Capriciossa();
                    break;
                case "Vegeteriana":
                    pizza = new Vegetirana();
                    break;
                default:
                    throw new ArgumentException("Invalid pizza name");
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Serve();
            pizza.Charge();
            
            return pizza;
        }

        public static Pizza GetPizzaButBetter(string name) => GetPizzaByName(name);
        
        private static Pizza GetPizzaByName(string name)
        {
            Type type = Type.GetType(name);
            return Activator.CreateInstance(type) as Pizza;
        }
    }
}