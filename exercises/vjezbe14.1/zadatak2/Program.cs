using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2
{
    internal class Program
    {
        private delegate void Broadcast(string message);
        static void Main(string[] args)
        {
            string message = "Sretna Nova godina!";
            PerformMulticast(message);
            PerformMultiActions(message);


        }

        private static void PerformMultiActions(string message)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MULTICAST ACTIONS");
            Action<string> email = SendEmail;
            Action<string> messageBroadcast = SendMessage;


            Action<string> multicast = email + messageBroadcast;
            multicast(message);

            // micanje
            multicast -= email;
            multicast -= messageBroadcast;

            // Sad dobijes: System.NullReferenceException: Object reference not set to an instance of an object.
            // nemas delegata pa je null ref
            // multicast(message);
            multicast?.Invoke(message);
        }

        private static void PerformMulticast(string message)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("MULTICAST");
            Broadcast email = SendEmail;
            Broadcast messageBroadcast = SendMessage;
            
           
            Broadcast multicast = email + messageBroadcast;
            multicast(message);

            // koristenjem lambde dodati neki izraz u multicast
            //  multicast += (text) => Console.WriteLine($"Slanje teksta: {text}");
            //  multicast(message);

            // paziti, ovo ce prebrisati ostale delegate
            // multicast = (text) => Console.WriteLine($"Slanje teksta: {text}");

            // micanje
            multicast -= email;
            multicast -= messageBroadcast;

           // Sad dobijes: System.NullReferenceException: Object reference not set to an instance of an object.
           // nemas delegata pa je null ref
           // multicast(message);
           multicast?.Invoke(message);

        }

        private static void SendMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Message: {message}");
        }

        private static void SendEmail(string message) 
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Email: {message}");
        }
    }
}
