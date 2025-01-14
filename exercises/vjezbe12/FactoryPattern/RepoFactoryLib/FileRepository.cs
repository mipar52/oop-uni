using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using RepoFactoryLib.Model;

namespace RepoFactoryLib
{
    internal class FileRepository: IRepository
    {
        private const string ItemsPath = "/Users/milanparadina/Desktop/data/items.txt";
        private const string UsersPath = "/Users/milanparadina/Desktop/data/users.txt";

        internal FileRepository()
        {
            if (!File.Exists(ItemsPath))
            {
                File.Create(ItemsPath).Close();
            }

            if (!File.Exists(UsersPath))
            {
                File.Create(UsersPath).Close();
            }
        }
        public void AddItem(Item item)
        {
            AddUser(item.User);
            ISet<Item> items = GetItems();
            items.Add(item);
            File.WriteAllLines(ItemsPath, items.Select(x => x.Format()));
        }

        public ISet<Item> GetItems()
        {
            ISet<Item> items = new HashSet<Item>();
            string[] lines = File.ReadAllLines(ItemsPath);
            lines.ToList().ForEach(line => items.Add(Item.Parse(line)));
            return items;
        }

        private void AddUser(User user)
        {
            ISet<User> users = GetUsers();
            users.Add(user);
            string[] lines = new string[users.Count];
            int i = 0;
            foreach (User userLine in users)
            {
                lines[i] = userLine.Format();
                i++;
            }
            // jednostavnije ima i -> users.Select(x => x.Format());
            File.WriteAllLines(UsersPath, lines);
        }

        public User GetUser(int id) => GetUsers().FirstOrDefault(u => u.Id == id);
        
        public ISet<User> GetUsers()
        {
            ISet<User> users = new HashSet<User>();
            string[] userLines = File.ReadAllLines(UsersPath);
            foreach (string userLine in userLines)
            {
                User currentUser = new User();
                User.Parse(userLine);
                users.Add(currentUser);
            }
            return users;
        }
    }
}