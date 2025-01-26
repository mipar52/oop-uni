using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zadatak01.Delegates;
using zadatak01.Model;

namespace zadatak01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserManager manager = new UserManager();
                manager.OnError += onErr;
                manager.OnLoad += onLoad;
                IDictionary<string, User> dict = manager.Users;
                Console.WriteLine(dict);
            }
            catch (Exception ex)
            {
                Show(ex.Message, ConsoleColor.Red);
            }
        }

        private static void onErr(object sender, ErrorArgs args)
        {
            Show(args.Exception.Message, ConsoleColor.Red);
        }

        private static void onLoad(object sender, LoadedEventArgs args)
        {
            if(args.BrokenUserInfo.Count == 0)
            {
                Show(args.User.ToString(), ConsoleColor.Green);
            } else
            {

                Show(string.Join(", ", args.BrokenUserInfo), ConsoleColor.Blue);
            }
        }

        private static void Show(string message, ConsoleColor red)
        {
            Console.ForegroundColor = red;
           Console.WriteLine($"{message}");
            Console.ResetColor();
        }
    }
}
