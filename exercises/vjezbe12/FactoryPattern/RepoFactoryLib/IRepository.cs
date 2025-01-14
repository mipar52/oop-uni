using System.Collections.Generic;
using RepoFactoryLib.Model;

namespace RepoFactoryLib
{
    public interface IRepository
    {
        void AddItem(Item item);
        ISet<Item> GetItems();
        User GetUser(int id);
        ISet<User> GetUsers();
    }
}