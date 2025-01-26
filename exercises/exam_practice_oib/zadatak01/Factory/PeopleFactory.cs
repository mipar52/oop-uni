using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadatak01.Model;

namespace zadatak01.Factory
{
    internal class PeopleFactory : IRepo
    {
        private const string dir = @"E:\Faks_Racunarstvo\Treci semestar\git_projects\oop\exercises\exam_practice_oib\zadatak01";
        private const string path = dir + @"\people.txt";

        public PeopleFactory() 
        { 
            Directory.CreateDirectory(dir);
            if(!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public IList<User> GetUsers()
        {
            IList<User> users = new List<User>();
            string[] lines = File.ReadAllLines(path);

            foreach(var line in lines)
            {
                User user = User.Parse(line);
                users.Add(user);
            }
            return users;
        }

        public void SaveUsers(IList<User> users)
        {
            string[] lines = new string[users.Count];
            int i = 0;
            foreach (var user in users) 
            {
                string line = user.Format();
                lines[i++] = line;
            }
            File.WriteAllLines(path, lines);
            // File.WriteAllLines(path, users.Select(x => x.Format()));
        }
    }
}
