using System.Collections.Generic;

namespace RepoFactory
{
    public interface IRepository
    {
        ISet<User> GetUsers();
        ISet<Item> GetItems();
        void AddItem(Item item);
        void AddUser(User user);
    }
}