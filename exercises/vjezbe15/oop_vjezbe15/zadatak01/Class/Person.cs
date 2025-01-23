using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak01.Class
{
    public class Person
    {
        private const char DEL = '|';
        public string Oib {  get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public override string ToString() => $"{this.Oib}, {this.Ime}, {this.Prezime}, {this.Telefon}, {this.Email}";
        internal string FormatForFileLine() => $"{this.Oib}{DEL}{this.Ime}{DEL}{this.Prezime}{DEL}{this.Telefon}{DEL}{this.Email}";
        internal static Person ParseFromFileLine(string line)
        {
            string[] details = line.Split(DEL);
            // gledas na poziciju ovaj .lenght > 1, to se gleda zapravo pozicija 
            return new Person 
            { 
                Oib =       details[0], 
                Ime =       details.Length    > 1 ? details[1] : string.Empty, 
                Prezime =   details.Length    > 2 ? details[2] : string.Empty, 
                Telefon =   details.Length    > 3 ? details[3] : string.Empty, 
                Email =     details.Length    > 4 ? details[4] : string.Empty
            };
        }

        internal bool HasValidOIB() => Oib.Length == 11 && Oib.All(char.IsDigit);
    }
}
