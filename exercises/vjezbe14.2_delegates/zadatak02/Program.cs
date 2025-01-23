using System;
using System.IO;
using System.Net.NetworkInformation;

namespace zadatak02
{
    internal class Program
    {
        private delegate void Broadbcast(string message);
        public static void Main(string[] args)
        {
            string message = "Otepo ga ko Zoki Dragana";
            Notify(message);
        }

        private static void Notify(string message)
        {
            Broadbcast email = SendEmail; // dodavanje subscribera
            email(message);
            Broadbcast sms = SendSms;
            sms(message);
            Console.WriteLine();
            
            // konkateniranje poziva
            Broadbcast multicast = email + sms; // one to many relationship
            multicast += Ping;
            // multicast = null; // sprijeciti
            multicast.Invoke(message);
            multicast(message);
            
            Console.WriteLine();
            multicast -= Ping; // unsubscribe
            multicast.Invoke(message);
            
            Console.WriteLine();
            multicast += m => Console.WriteLine("lamba: " + message);
            // lamda se ne moze unsubscribati jer je anon method
            multicast -= m => Console.WriteLine("lamba: " + message);  


        }

        private static void Ping(string message) => Console.WriteLine("ping: " + message);
        private static void SendSms(string message) => Console.WriteLine("sms: " + message);
        private static void SendEmail(string message) => Console.WriteLine("email: " + message);
    }
}