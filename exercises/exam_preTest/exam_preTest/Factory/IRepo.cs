using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_preTest.Model;

namespace exam_preTest.Factory
{
    public interface IRepo
    {
        void SaveUser(ISet<User> users);
        ISet<User> GetUsers();
    }
}
