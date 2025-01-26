using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak01.Delegates
{
    public class ErrorArgs: EventArgs
    {
        public Exception Exception {  get; set; }
    }

    public delegate void ErrorDelegate(object sender, ErrorArgs args);
}
