namespace RepoFactory
{
    public class User
    {
        private const char del = '|'; 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public string Format() => $"{FirstName}{del}{LastName}{del}{Email}";
        public static User Parse(string line)
        {
            string[] parts = line.Split(del);
            return new User(parts[0], parts[1], parts[2]);
        }

        public override string ToString() => $"{FirstName}, {LastName}, {Email}";

        public override bool Equals(object obj)
        {
            if (obj is User user)
            {
                return user.Email == this.Email;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode();
        }
    }
}