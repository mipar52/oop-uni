using System.Collections.Generic;

namespace zadatak01
{
    public class Zupanija
    {
        public int id { get; set; }
        public string Naziv { get; set; }
    
        public List<Grad> gradovi { get; set; }
        
        public Zupanija(int id, string naziv)
        {
            this.id = id;
            this.Naziv = naziv;
        }
    }
}