using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod2.Class
{
    internal class Projector : Device
    {
        public string Resolution { get; set; }

        public Projector(string manufacturer, string model, string color, string resolution) : base(manufacturer, model, color)
        {
            Resolution = resolution;
            Console.WriteLine("Created new projector!");
        }

    
        public override string ToString() => $"Projector info: {base.ToString()}, Resolution: {this.Resolution}\n";

        public override bool Equals(object obj)
        {
            if (obj is Projector other)
            {
                return base.Equals(other) && this.Resolution == other.Resolution;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override void TurnOn()
        {
            Console.WriteLine("Projector on!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Projector off!");
        }
    }
}
