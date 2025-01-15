using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using zadatak02.Model;

namespace zadatak02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableList list = new ObservableList();
            list.OnOperation += Operacija;

            int count = 0;
            do
            {
                Random rnd = new Random();
                int element = rnd.Next(1, 100);
                list.Add(element);
                Thread.Sleep(500);
                list[0] = element;
                Thread.Sleep(500);
                list.Remove(element);
                Thread.Sleep(500);
                count++;
            } while (count < 100);

        }

        private static void Operacija(object sender, ListOperationEventArgs e)
        {
            switch (e.Operation) 
            { 
            
                case OperationType.Add:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case OperationType.Update:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case OperationType.Delete:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine($"{e.Operation}, {e.Value}, {e.Time}");
        }
    }
}
