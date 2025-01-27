using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_preTest.Model
{
    public class User: IComparable<User>
    {
        private const char del = '|';
        public string Oib {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public User(string oib, string firstName, string lastName, string telephone, string email)
        {
            Oib = oib;
            FirstName = firstName;
            LastName = lastName;
            Telephone = telephone;
            Email = email;
        }

        public override string ToString() => $"{Oib}: {FirstName}, {LastName}, {Telephone}, {Email}";

        public override bool Equals(object obj) => obj is User user && Oib == user.Oib;
        public override int GetHashCode() => 154796797 + EqualityComparer<string>.Default.GetHashCode(Oib);
        public int CompareTo(User other) => Oib.CompareTo(other.Oib);

        public static User Parse(string userLine)
        {
            string[] line = userLine.Split(del);
            return new User(
                line[0],
                line.Length > 1 ? line[1] : string.Empty,
                line.Length > 2 ? line[2] : string.Empty,
                line.Length > 3 ? line[3] : string.Empty,
                line.Length > 4 ? line[4] : string.Empty
                );
        }

        public string Format() => $"{Oib}|{FirstName}|{LastName}|{Telephone}|{Email}";
        public bool IsOibValid => Oib.Length == 11 && Oib.All(char.IsDigit);
    }
}
