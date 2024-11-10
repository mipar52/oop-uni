using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje03
{
    internal class Student
    {
        // po defaultu, propertijes su privatni
        public string ime;
        public string prezime;
        string jmbag;
        int godinaStudija;

        // staticko pripada klasi. Ono se kreira jednom. Klasa.staticProperty. Moze se koristiti bez da ima iti jednu instancu
        private static int studentCounter;

        public Student(string ime, string prezime, int godinaStudija)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbag = "IP24-" + (++studentCounter);
            this.godinaStudija = godinaStudija;
            // this -> pointer na objekt -> upravo taj objekt koji se stvara
        } 
        // prazni konstruktor    
        public Student() 
        {
            this.ime = "John";
            this.prezime = "Doe";
            this.jmbag = "0000000000"
            this.godinaStudija = 0;
        }

        override public string ToString()
        {
            return $"JMBAG: {ime}\nIme i prezime: {ime} {prezime}\nGodina studija: {godinaStudija}";
        }
    }
}