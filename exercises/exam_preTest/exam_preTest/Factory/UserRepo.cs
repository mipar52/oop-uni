using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_preTest.Model;

namespace exam_preTest.Factory
{
    internal class UserRepo : IRepo
    {
        private const string dir = @"E:\Faks_Racunarstvo\Treci semestar\OOP\exam_preTest\exam_preTest\";
        private const string path = dir + "people.txt";

        public UserRepo() 
        { 
            Directory.CreateDirectory(dir);
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public ISet<User> GetUsers()
        {
            ISet<User> users = new HashSet<User>();
            string[] userLines = File.ReadAllLines(path);
            foreach (string userLine in userLines)
            {
                users.Add(User.Parse(userLine));
            }

            return users;
        }

        void SaveUser(ISet<User> users)
        {
            string[] userLines = new string[users.Count];
            int index = 0;
            foreach(var user in users)
            {
                userLines[index++] = user.Format();
            }
            File.WriteAllLines(path, userLines);
        }

        void IRepo.SaveUser(ISet<User> users)
        {
        }
    }
}
