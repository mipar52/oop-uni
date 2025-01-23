using System.Collections.Generic;
using System.IO;
using System.Net;

namespace RepoFactory
{
    public class FileRepository: IRepository
    {
        private const string usersFilePath =
            "/Users/milanparadina/Desktop/CSProjects/exam_practice/RepoFactory/users.txt";

        private const string itemsFilePath =
            "/Users/milanparadina/Desktop/CSProjects/exam_practice/RepoFactory/items.txt";

        public FileRepository()
        {
            if (!File.Exists(itemsFilePath)) { File.Create(itemsFilePath).Close(); }
            if (!File.Exists(usersFilePath)) { File.Create(usersFilePath).Close(); }
        }
        public ISet<User> GetUsers()
        {
            ISet<User> users = new HashSet<User>();
            string[] lines = File.ReadAllLines(usersFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                users.Add(User.Parse(line));
            }
            return users;
        }

        public ISet<Item> GetItems()
        {
            ISet<Item> items = new HashSet<Item>();
            string[] lines = File.ReadAllLines(itemsFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                Item item = Item.Parse(lines[i]);
                items.Add(item);
            }
            return items;
        }

        public void AddItem(Item item)
        {
            ISet<Item> items = GetItems();
            if (!items.Contains(item))
            {
                File.WriteAllText(itemsFilePath, item.Format());
            }
        }

        public void AddUser(User user)
        {
            ISet<User> users = GetUsers();
            if (!users.Contains(user))
            {
                users.Add(user);
                File.WriteAllText(usersFilePath, user.Format());
            }
        }
    }
}