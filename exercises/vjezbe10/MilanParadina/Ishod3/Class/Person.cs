using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod3.Class
{
    internal class Person: IBuildable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"Person info: {this.FirstName} {this.LastName}";

        public void build()
        {
            Console.WriteLine("Building the human body...");
            Console.WriteLine("..");
            Console.WriteLine("..");
            Console.WriteLine("..");
            Console.WriteLine($"Built the human!!\n{this.ToString()}\n");
        }
    }
}
