using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zadatak04.Model;


namespace zadatak01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientHost host = new ClientHost();
            host.OnClientArrived += CallBoss;
            host.OnClientArrived += CallWife;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Prvi klijent");
            host.ClientHasArrived(new Client("Ivo", "ivic"));

            host.OnClientArrived -= CallWife;
            host.OnClientArrived += CallWife;

            while (true)
            {
                host.ClientHasArrived(new Client("Milica", "Krmpotic"));
                Thread.Sleep(1000);
            }
        }

        private static void CallWife(object sender, ClientArrivedEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Zeno nemoj zvat, dosao je: {args.Client.ToString()}");
        }

        private static void CallBoss(object sender, ClientArrivedEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dosa client: {args.Client.ToString()}");
        }
    }
}
