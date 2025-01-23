namespace delegate_practice1.Model
{
    public class AnimalHost
    {
        public event AnimalDelegate AnimalEvent;
        
        public void PrintAnimal(Animal animal) => AnimalEvent.Invoke(this, new AnimalDelegateArgs { Animal = animal});
    }
}