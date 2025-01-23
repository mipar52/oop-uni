using System;
using System.Threading;
using delegate_practice1.ModelTwo;

namespace delegate_practice1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CarHost host = new CarHost();
            host.onCarArrivedEventArgs += AudiArrived;
            host.onCarArrivedEventArgs += BWMArrived;

            while (true)
            {
                host.CarHasArrived(new Car("BMW", "Black"));
                Thread.Sleep(1000);
            }
        }

        private static void BWMArrived(object sender, CarArrivedEventArgs args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(args.Car.ToString());

        }

        private static void AudiArrived(object sender, CarArrivedEventArgs args)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine(args.Car.ToString());
        }
    }
}