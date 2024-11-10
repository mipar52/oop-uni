using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje03
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Student s1 = new Student();
            // na stacku se pohranjuju lokalne varijable + primitivni tipovi
            // svi ostali objekti se spremaju se na heapu

            // s1 -> varijabla, na stacku, koja sadrzi pointer na objekt na heapu
            // new -> stvara se objekt na heapu, salje se adresa na hepu (pointer na objekt na hepu)

            Console.WriteLine(s1.Name); 
            // -> dobije se null, al se compilea i radi. Zato jer se member varijable (varijable unutar instanci) ne moraju inicijalizirati
            
            // konstruktor -> metoda pomocu koje se puno stvari u klasi
            // zove se isto kao i klasa i nema povratnu vrijednost
            Student s2 = new Student("Marko", "Maric", "193849384", 2);

            // garbage collection
            // C# radi automatski. ne mora se eksplicitno releasati memorija

            //IDisposable i Dispose() -> interface i njegova metoda u kojoj mozes napraviti 'dodatno' cisenje prije dealokacije objekta (kao defer u swiftu)
        }

    }
}