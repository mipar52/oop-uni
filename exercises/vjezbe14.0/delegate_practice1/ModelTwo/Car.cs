namespace delegate_practice1.ModelTwo
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public override string ToString() => $"{Brand} {Model}";

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}