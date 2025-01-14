using System;

namespace PizzaFactory.Solution
{
    public abstract class Pizza
    {
        public abstract string Ingredients { get; set; }
        public abstract double Price { get; set; }
        public void Prepare() => Console.WriteLine($"{GetType().Name} {nameof(Prepare)}");
        public void Bake() => Console.WriteLine($"{GetType().Name} {nameof(Bake)}");
        public void Serve() => Console.WriteLine($"{GetType().Name} {nameof(Serve)}");
        public void Charge() => Console.WriteLine($"{GetType().Name} {nameof(Charge)}: {Price}");
        
        public override string ToString() => $"{GetType().Name} {Ingredients}";
    }
}