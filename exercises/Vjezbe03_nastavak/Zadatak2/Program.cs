using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.ToString());

            Student student2 = new Student("Maja", "Majic");
            Console.WriteLine(student2.ToString());

            // kako se mogu initat objekti, ali kad su varijable public lmaoo
            /*
            Student student1 = new Student
            {
                YearOfStudy = 2,
                Prosjek = 3.5
            };

            Student student3 = new Student ("Ana", "Anic")
            {
                GodinaStudiranja = 4,
                Prosjek = 3.1
            };
             * 
             */

        }
    }
}
