using System.Collections.Generic;
using System.Linq;
using RepoFactoryLib.Model;

namespace RepoFactoryLib
{
    internal class MemoryRepository: IRepository
    {
        private static ISet<User> users = new HashSet<User>();
        private static ISet<Item> items = new HashSet<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
            users.Add(item.User);
        }
        public ISet<Item> GetItems() => new HashSet<Item>(items);
        public User GetUser(int id) => GetUsers().FirstOrDefault(x => x.Id == id);
        public ISet<User> GetUsers() => new HashSet<User>(users);
    }
}