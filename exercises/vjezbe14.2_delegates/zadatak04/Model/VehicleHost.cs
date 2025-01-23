namespace zadatak04.Model
{
    public class VehicleHost
    {
        public event VehicleDelegate VehicleAdded;
        public void VehicleHasAdded(Vehicle vehicle) => VehicleAdded?.Invoke(this, new VechicleDelegateEventArgs { Vehicle = vehicle }); 
    }
}