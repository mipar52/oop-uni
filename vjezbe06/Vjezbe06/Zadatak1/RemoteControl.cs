using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class RemoteControl : IRemoteControl
    {
        public void SwitchOff()
        {
            Console.WriteLine("Remote control off");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Remote control on");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Remote control volume dowm");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Remote control volume up");
        }
    }
}
