using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadatak01.Model;

namespace zadatak01.Factory
{
    internal interface IRepo
    {
        void SaveUsers(IList<User> users);
        IList<User> GetUsers();
    }
}
