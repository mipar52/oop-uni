using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak01.Model
{
    public class User: IComparable<User>
    {
        private const char del = '|';
        public string Oib {  get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public User(string oib, string name, string lastName, string brojTelefona, string email)
        {
            Oib = oib;
            Name = name;
            LastName = lastName;
            BrojTelefona = brojTelefona;
            Email = email;
        }
        public override string ToString() => $"{Oib}, {Name}, {LastName}, {BrojTelefona}, {Email}";
        public static User Parse(string fileLine)
        {
            string[] strings = fileLine.Split(del);
            return new User(
               strings.Length > 0 ? strings[0] : "",
               strings.Length > 1 ? strings[1] : "",
               strings.Length > 2 ? strings[2] : "",
               strings.Length > 3 ? strings[3] : "",
               strings.Length > 4 ? strings[4] : ""
               );
        }

        public string Format() => $"{Oib}{del}{Name}{del}{LastName}{del}{BrojTelefona}{del}{Email}";

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Oib == user.Oib;
        }

        public override int GetHashCode()
        {
            return 154796797 + EqualityComparer<string>.Default.GetHashCode(Oib);
        }

        public int CompareTo(User other) => Oib.CompareTo(other.Oib);

        public bool HasValidOib() => Oib.Length == 11 && Oib.All(char.IsDigit);
    }
}
