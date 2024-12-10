using Ishod3.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(1500.2, 20000.43, 300);
            Computer computer = new Computer(1024, 32);
            Person person = new Person("John", "Doe");

            List<IBuildable> buildables = new List<IBuildable> { building, computer, person };
            foreach (var buildable in buildables) { buildable.build(); }
        }
    }
}
