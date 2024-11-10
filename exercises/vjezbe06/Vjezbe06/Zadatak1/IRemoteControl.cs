using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal interface IRemoteControl: ISwitchable
    {
        void VolumeUp();
        void VolumeDown();
    }
}