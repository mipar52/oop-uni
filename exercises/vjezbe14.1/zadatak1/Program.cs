using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak1
{
    internal class Program
    {
        private delegate double Operation(double a, double b);
        static void Main(string[] args)
        {
            double a = 5.1;
            double b = 2.3;
            PerformOperations(a, b);
            PerformFunctions(a, b);

        }

        private static void PerformFunctions(double a, double b)
        {
            Console.WriteLine("Operacije:");
            Func<double, double, double> operation = Add;
            Console.WriteLine($"{a} + {b} = {operation(a, b)}");
            operation = Subtract;
            Console.WriteLine($"{a} - {b} = {operation(a, b)}");
            operation = Multiply;
            Console.WriteLine($"{a} * {b} = {operation(a, b)}");
            operation = Divide;
            Console.WriteLine($"{a} / {b} = {operation(a, b)}");

            // history lesson
            // C# delegate moze se inicijalizirati unutar koda ("anonymous method")
            operation = delegate (double x, double y) { return Math.Pow(x, y); };
            Console.WriteLine($"{a} pow {b} = {operation(a, b)}");

            // C# 3.0 delegate moze se inicijalizirati upotrebom lambde
            operation = (x, y) => Math.Pow(x, y);

            // ukoliko se koriste metode s istim potpisom
            operation = Math.Pow;

            // metoda ili delegat mogu se takoder poslati putem metode
            // time odvajamo pozivatelja od pozvanog
            Console.WriteLine($"{a} pow {b} = {PerformFunction(a, b, Math.Pow)}");

            // prosirenje pomoci lambde
            Console.WriteLine($"{a} + {b} = {PerformFunction(a, b, (x, y) => x + y)}");
            Console.WriteLine($"{a} pow {b} = {operation(a, b)}");
        }

        private static object PerformFunction(double a, double b, Func<double, double, double> function) => function(a, b);

        private static void PerformOperations(double a, double b)
        {
            Console.WriteLine("Operacije:");
            Operation operation = Add;
            Console.WriteLine($"{a} + {b} = {operation(a,b)}");
            operation = Subtract;
            Console.WriteLine($"{a} - {b} = {operation(a, b)}");
            operation = Multiply;
            Console.WriteLine($"{a} * {b} = {operation(a, b)}");
            operation = Divide;
            Console.WriteLine($"{a} / {b} = {operation(a, b)}");

            // history lesson
            // C# delegate moze se inicijalizirati unutar koda ("anonymous method")
            operation = delegate (double x, double y) { return Math.Pow(x, y); };
            Console.WriteLine($"{a} pow {b} = {operation(a, b)}");

            // C# 3.0 delegate moze se inicijalizirati upotrebom lambde
            operation = (x, y) => Math.Pow(x, y);

            // ukoliko se koriste metode s istim potpisom
            operation = Math.Pow;

            // metoda ili delegat mogu se takoder poslati putem metode
            // time odvajamo pozivatelja od pozvanog
            Console.WriteLine($"{a} pow {b} = {PerformOperation(a, b, Math.Pow)}");

            // prosirenje pomoci lambde
            Console.WriteLine($"{a} + {b} = {PerformOperation(a, b, (x, y) => x + y)}");
            Console.WriteLine($"{a} pow {b} = {operation(a, b)}");

        }

        private static object PerformOperation(double a, double b, Operation operation) => operation(a, b);

        private static double Divide(double a, double b) => a == 0 || b == 0 ? 0 : a / b;

        private static double Multiply(double a, double b) => a * b;

        private static double Subtract(double a, double b) => a - b;

        private static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
