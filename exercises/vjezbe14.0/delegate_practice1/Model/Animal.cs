namespace delegate_practice1.Model
{
    public class Animal
    {
        public string Name {get; set;}
        public string AnimalType { get; set; }

        public Animal(string name, string animalType)
        {
            Name = name;
            AnimalType = animalType;
        }
    }
}