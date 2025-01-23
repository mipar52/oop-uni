using System.CodeDom.Compiler;

namespace RepoFactory
{
    public class Item
    {
        private const char del = '#';
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }

        public Item(int id, string itemName, string itemDescription)
        {
            Id = id;
            ItemName = itemName;
            ItemDescription = itemDescription;
        }
        public string Format() => $"{Id}{del}{ItemName}{del}{ItemDescription}";
        public static Item Parse(string line)
        {
            string[] parts = line.Split(del);
            return new Item(int.Parse(parts[0]), parts[1], parts[2]);
        }
    }
}