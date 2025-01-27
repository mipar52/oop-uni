using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_preTest.Model;

namespace exam_preTest.Delegate
{
    public class LoadEvent: EventArgs
    {
        public User User { get; set; }
        public (string, IList<String>) BrokenUsers { get; set; }
    }

    public delegate void OnLoadedDelegate(object sender, LoadEvent e);
}
