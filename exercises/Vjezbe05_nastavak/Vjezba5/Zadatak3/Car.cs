using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Car
    {
        public int VehicleNumber {  get; set; }
        public string Type {  get; set; }
        public double Acceleration {  get; set; }
        public Car(int VehicleNumber, string Type, double Acceleration): base() //dodaje se implicitno -> ne moras dodavati -> dolazi od Object klase
        {
            this.VehicleNumber = VehicleNumber;
            this.Type = Type;
            this.Acceleration = Acceleration;
        }

        // da se metoda moze naslijediti ona mora biti virtualna -> takvu metodu kasnije mozemo overridati
        public virtual void Drive() => Console.WriteLine("Car is driving...");
        public virtual void Stop() => Console.WriteLine("Car stopping...");
        public override string ToString()
        {
            return $"Broj: {VehicleNumber}, Tip: {Type}, Ubrzanje: {Acceleration}";
        }
    }
}
