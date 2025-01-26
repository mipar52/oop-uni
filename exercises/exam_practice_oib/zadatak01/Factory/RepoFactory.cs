using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak01.Factory
{
    internal class RepoFactory
    {
        public static IRepo GetRepository() => new PeopleFactory();
    }
}
