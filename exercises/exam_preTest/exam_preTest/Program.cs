using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_preTest.Delegate;
using exam_preTest.Model;

namespace exam_preTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserManager manager = new UserManager();
                manager.onLoaded += onLoadedUser;
                manager.onException += onFailedUser;
                IDictionary<string, User> users = manager.Users;
            }
            catch (Exception ex) 
            { 
                Print(ex.Message, ConsoleColor.Magenta);
            }

        }

        private static void onFailedUser(object sender, ExceptionEvent e)
        {
            Print(e.Exception.Message, ConsoleColor.Red);
        }

        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }

        private static void onLoadedUser(object sender, LoadEvent e)
        {
            Print($"{e.User.Oib} : {e.User.ToString()}", ConsoleColor.DarkGreen);
            if (!(e.BrokenUsers.Item1 == string.Empty)) 
            {
                string oib = e.BrokenUsers.Item1;
                IList<string> users = e.BrokenUsers.Item2;
                Print($"Broken user info -> {e.BrokenUsers.Item1}: {String.Join(", ", e.BrokenUsers.Item2.ToList())}", ConsoleColor.DarkYellow);
            }
        }


    }
}
