using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Student
    {
        private string Name;
        private string Surname;
        private int GodinaStudija;
        private double Prosjek;


        public Student()
        {
            this.Name = "Pero";
            this.Surname = "Perić";
        }

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

       // radi istu stvar kao linije 23 - 27 -> public Student() : this("Pero", "Peric") { };

        public string getName() 
        {
            return Name;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getSurname()
        {
            return Surname;
        }
        public void setSurname(string surname)
        {
            this.Surname = surname;
        }
        public int getGodinaStudija()
        {
            return GodinaStudija;
        }
        public void setGodinaStudija(int godinaStudija)
        {
            this.GodinaStudija = godinaStudija;
        }
        public double getProsjek()
        {
            return Prosjek;
        }
        public void setProsjek(double prosjek)
        {
            this.Prosjek = prosjek;
        }

        public override string ToString()
        {
            return $"Student info:\nIme: {Name}, Prezime: {Surname}, Godina Studija: {GodinaStudija}, Prosjek: {Prosjek}";
        }
    }
}
