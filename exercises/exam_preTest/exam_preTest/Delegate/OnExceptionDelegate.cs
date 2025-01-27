using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_preTest.Delegate
{
    public class ExceptionEvent: EventArgs
    {
        public Exception Exception {  get; set; }
    }
    public delegate void OnExceptionDelegate(object sender, ExceptionEvent e);
}
