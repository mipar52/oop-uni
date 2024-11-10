using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class SportCar: Car
    {
        public bool RoofWindow { get; set; }
        //CS7036: There is no argument given that corresponds to the required parameter
        // ovo znaci da se konkstruktori se ne nasljeduju! moras napravit svoj konstruktor i dodati konstukrtor u parenta


        // ovo je implicitni konstruktor i to ne radi. Zato jer roditelj nema defaultni konstruktor bez parametara
        //  public SportCar(int Ve): base()
        //  {    
        //  }

        public SportCar(int VechnicleNumber, string Type, double acceleration, bool roofWindow):
            base(VechnicleNumber, Type, acceleration) 
        { 

        }

        public void Drift() => Console.WriteLine("Car is drifting!");

        //metore Drive() i Stop() ne re-iskoristavaju implementaciju od roditelja

        public override void Drive()
        {
            Console.WriteLine("Sport car driving!");
        }
        public override void Stop()
        {
            Console.WriteLine("Sport car stopping!");
        }

        public override string ToString() => $"{base.ToString()}, Roof window: {(this.RoofWindow ? "da" : "ne")}";

    }
}
