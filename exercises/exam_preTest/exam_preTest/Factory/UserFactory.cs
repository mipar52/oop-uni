using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_preTest.Factory
{
    public class UserFactory
    {
       public static IRepo GetRepository() => new UserRepo();
    }
}
