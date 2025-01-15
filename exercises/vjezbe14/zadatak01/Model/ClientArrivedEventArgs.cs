using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak04.Model
{
    public class ClientArrivedEventArgs : EventArgs
    {
        public Client Client { get; set; }
    }
}
