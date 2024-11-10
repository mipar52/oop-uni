using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISwitchable lightbulb = new Lightbulb 
            { 
                Lenght = 5,
                Power = 5
            };

            Console.WriteLine(lightbulb.ToString());
            lightbulb.SwitchOn();
            lightbulb.SwitchOff();

            ISwitchable stove = new Stove
            {
                Producer = "Gorenje",
                Type = Stove.StoveType.Struja
            };
            Console.WriteLine(stove.ToString());

            IRemoteControl remoteController = new RemoteControl();
            remoteController.SwitchOn();
            remoteController.SwitchOff();
            remoteController.VolumeUp();
            remoteController.VolumeDown();

            List<ISwitchable> electonics = new List<ISwitchable> { lightbulb, stove, remoteController };

            foreach (var switchable in electonics) 
            { 
                switchable.SwitchOn();
                switchable.SwitchOff();

                if (switchable is IRemoteControl irc)
                {
                    irc.VolumeUp();
                    irc.VolumeDown();
                }
            }

        }
    }
}
