using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod2.Class
{
    public abstract class Device
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }


        public abstract void TurnOn();
        public abstract void TurnOff();



        protected Device(string manufacturer, string model, string color)
        {
            Manufacturer = manufacturer;
            Model = model;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (obj is Device other) 
            { 
                return this.Manufacturer == other.Manufacturer && this.Color == other.Color;
            }
            return false;
        }

        public override int GetHashCode() 
        { 
            return this.GetHashCode();
        }

        public override string ToString() => $"Manufacturer: {this.Manufacturer}, Model: {this.Model}, Color: {this.Color}";

    }
}
