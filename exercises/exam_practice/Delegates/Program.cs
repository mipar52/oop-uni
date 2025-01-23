using System;
using System.Threading;

namespace Delegates
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UserHost host = new UserHost();
            host.onUserArrived += UserOneArrived;
            host.onUserArrived += UserTwoArried;

            while (true)
            {
                host.UserHasArrived(new User("Milica", "Krmpotic", 65));
                Thread.Sleep(1000);
            }
        }
        

        private static void UserTwoArried(object sender, UserEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dobro je ljudi, došao je {e.User.ToString()}");
        }

        private static void UserOneArrived(object sender, UserEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Pazite ljudi, došao je {e.User.ToString()}");
        }
    }
}