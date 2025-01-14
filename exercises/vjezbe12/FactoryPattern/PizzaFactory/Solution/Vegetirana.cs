namespace PizzaFactory.Solution
{
    public class Vegetirana: Pizza
    {
        public override string Ingredients { get; set; } = "Vegetables";
        public override double Price { get; set; } = 13.99;
    }
}