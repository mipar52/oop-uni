namespace RepoFactoryLib.Model
{
    public class User
    {
        private const char delimiter = '|';
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
        public string Format() => $"{Id}{delimiter}{FirstName}{delimiter}{LastName}";
        public static User Parse(string line)
        {
            string[] userInfos = line.Split(delimiter);
            return new User { Id = int.Parse(userInfos[0]), FirstName = userInfos[1], LastName = userInfos[2] };
        }
        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is User && Id == (obj as User).Id;
        }
    }
}