using System;
using System.Globalization;

namespace RepoFactoryLib.Model
{
    public class Item
    {
        private const char Delimiter = '#'; 
        private const string DateFormat = "dd/MM/yyyy HH:mm:ss";
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

        public override string ToString() => $"{Description} {Date.ToString(DateFormat)} {User}";
        public string Format() => $"{Id}{Delimiter}{Description}{Delimiter}{Date.ToString(DateFormat)}{Delimiter}{User.Format()}{Delimiter}";

        public static Item Parse(string line)
        {
            string[] itemInfos = line.Split(Delimiter);
            foreach (var itemInfo in itemInfos)
            {
                Console.WriteLine(itemInfo);
            }
            return new Item
            {
                Id = int.Parse(itemInfos[0]), 
                Description = itemInfos[1], 
                Date = DateTime.ParseExact(itemInfos[2], DateFormat, null),
                User = User.Parse(itemInfos[3])
            };
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