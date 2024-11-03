using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(123, "Mecka", 9.3);
            car.Drive();
            car.Stop();

            SportCar sportCar = new SportCar(456, "Lamob", 100.01, true);
            Console.WriteLine(sportCar);
            sportCar.Drift();

            // implicitno upcastanje - svaki sport car je car
            Car car2 = sportCar;
            
            car2.Drive(); // -> pokazivat ce 'Sport car is driving...' -> nece od car uzimat nego od sportcara ono sta ima da je zajednicko

            //eksplicitno downcastanje - svaki car nije sport car
            //SportCar sportCar2 = (SportCar)car; // -> jako opasno btw

            if (car2 is SportCar sportCar2)
            {
                sportCar2.Drift();
            }

            Truck truck = new Truck(4949, "Kamijon", 10.3, 2220000);

            // prednosti poliformorfizma
            // 1 jedinstvena lista za sve car
            // lijeva strana nije specificirana - moze biti bilo koja IList (svaka se ponasa isto)
            // desna strana mora biti specificna List<Car>
            IList<Car> cars = new List<Car>()
            {
                car,
                sportCar,
                truck
            };
            Console.WriteLine();
            foreach(var c in cars)
            {
                c.Drive();
                c.Stop();
                if (c is SportCar sc2)
                {
                    sc2.Drift();
                }

            // jedinstvenu metodu za sve car
            PrintDetails(c);
            }
        }
        private static void PrintDetails(Car c) => Console.WriteLine(c);

    }
}
