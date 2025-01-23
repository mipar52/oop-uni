using System;
using System.Linq;

namespace RepoFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IRepository repo = RepoFactory.GetRepository();
            repo.AddUser(new User("Miki", "Mikic", "miki@mikic@gmail.com"));
            repo.AddUser(new User("Miki", "Mikic", "miki@mikic@gmail.com"));
            repo.AddUser(new User("Miki", "Mikic", "miki@mikic@gmail.com"));
            repo.AddUser(new User("Miki", "Mikic", "miki@mikic@gmail.com"));
            
            repo.AddItem(new Item(1, "Mikic", "miki@mikic@gmail.com"));
            repo.AddItem(new Item(1, "Mikic", "miki@mikic@gmail.com"));
            repo.AddItem(new Item(2, "Mikic", "miki@mikic@gmail.com"));
            repo.AddItem(new Item(4, "Mikic", "miki@mikic@gmail.com"));
            
            repo.GetItems().ToList().ForEach(Console.WriteLine);
            repo.GetUsers().ToList().ForEach(Console.WriteLine);
        }
    }
}