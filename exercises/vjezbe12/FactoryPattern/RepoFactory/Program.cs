using System;
using System.Linq;
using RepoFactoryLib;
using RepoFactoryLib.Model;

namespace RepoFactory
{
    internal class Program
    {
        private static IRepository repository = RepositoryFactory.GetRepository();
        public static void Main(string[] args)
        {
            FillItems();
            ReadItems();
            Console.WriteLine();
            ReadUsers();
            ReadUser(1);
        }

        private static void ReadUser(int id) => Console.WriteLine(repository.GetUser(id));
        private static void ReadUsers() => repository.GetUsers().ToList().ForEach(u => Console.WriteLine(u));
        private static void ReadItems() => repository.GetItems().ToList().ForEach(Console.WriteLine);
        private static void FillItems()
        {
            repository.AddItem(new Item
            {
                Id = 1, Date = DateTime.Today.AddDays(-2), Description = "Item 1", 
                User = new User { Id = 1 ,FirstName = "John", LastName = "Doe"}
            });
            repository.AddItem(new Item
            {
                Id = 2, Date = DateTime.Today.AddDays(-1), Description = "Item 2", 
                User = new User { Id = 2 ,FirstName = "Marina", LastName = "Marinic"}
            });
            repository.AddItem(new Item
            {
                Id = 3, Date = DateTime.Today.AddDays(-1), Description = "Item 3", 
                User = new User { Id = 2 ,FirstName = "Marina", LastName = "Marinic"}
            });
        }
    }
}