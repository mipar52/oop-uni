namespace delegate_practice1.ModelTwo
{
    public class CarHost
    {
        public CarArrivedDelegate onCarArrivedEventArgs;
        
        public void CarHasArrived(Car car) => onCarArrivedEventArgs.Invoke(car, new CarArrivedEventArgs { Car = car });
    }
}