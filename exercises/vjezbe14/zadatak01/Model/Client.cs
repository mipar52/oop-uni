using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak04.Model
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";

        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
