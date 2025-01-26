using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadatak01.Model;

namespace zadatak01.Delegates
{
    public class LoadedEventArgs: EventArgs
    {
       public User User { get; set; }
       public IList<string> BrokenUserInfo { get; set; }
    }

    public delegate void LoadDelegate(object sender, LoadedEventArgs args);
}