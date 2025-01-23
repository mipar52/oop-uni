using System;
using System.Threading;
using zadatak04.Model;

namespace zadatak04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            VehicleHost host = new VehicleHost();
            host.VehicleAdded += VehicleOneFunction;
            host.VehicleAdded += VehicleTwoFunction;

            while (true)
            {
                host.VehicleHasAdded(new Vehicle {Brand = "MBW", Model = "MW"});
                Thread.Sleep(1000);
            }

        }

        private static void VehicleTwoFunction(object sender, VechicleDelegateEventArgs args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(args.Vehicle.Model);
        }

        private static void VehicleOneFunction(object sender, VechicleDelegateEventArgs args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(args.Vehicle.Brand);
        }
    }
}