using System;

namespace PizzaFactory.Problem
{
    public class Cappriciosa
    {
        // auto-init read-only property
        public string Ingridient { get; } = "Tomato, Sauce, Ham, Magic Mushrooms";
        // auto-init property
        public double Price { get; set; } = 10.99;
        public void Prepare() => Console.WriteLine($"{GetType().Name} {nameof(Prepare)}");
        public void Bake() => Console.WriteLine($"{GetType().Name} {nameof(Bake)}");
        public void Serve() => Console.WriteLine($"{GetType().Name} {nameof(Serve)}");
        public void Charge() => Console.WriteLine($"{GetType().Name} {nameof(Charge)}: {Price}");
        public override string ToString() => $"{GetType().Name} {Ingridient}";
    }
}