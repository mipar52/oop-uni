using System;

namespace zadatak01
{
    // delegate -> u moje ime da neko nesto napravi
    internal class Program
    {
        private delegate double Operation(double a, double b);

        public static void Main(string[] args)
        {
            double a = 5.4;
            double b = 7.8;
            Perform(a, b);
        }

        private static void Perform(double d, double d1)
        {
            // u delegate trpamo funkciju koja ima isti potpis kao i delegat (u ovom slucaju dva doubla)
            // delegate ce samo napraviti ono sto ta funkcija napravi
            // ali sad nije tightly coupled na tu funkciju. mozes doslovno sad stavit bilo koju funkciju koja ima isti
            // potpis, ali moze raditi skroz nesto drugacije
            Console.WriteLine($"{d} + {d1} = {d + d1}");
            Operation operation = Add;
            Console.WriteLine($"{d} + {d1} = {operation(d, d1)}");
            
            operation = Substract;
            Console.WriteLine($"{d} - {d1} = {operation(d, d1)}");
            
            operation = Multiply;
            Console.WriteLine($"{d} * {d1} = {operation(d, d1)}");

            operation = Divide;
            Console.WriteLine($"{d} / {d1} = {operation(d, d1)}");

            operation = Math.Pow;
            Console.WriteLine($"{d} POW {d1} = {operation(d, d1)}");
            
            operation = (a, b) => a + b;
            Console.WriteLine($"{d} + {d1} = {operation(d, d1)}");
            
            // dodatno decouplanje
            PerformOperation(d, d1, operation);
            PerformOperation(d, d1, Add);
            PerformOperation(d, d1, (a, b) => a + b);
            
            Func<double, double, double> func = Add;
            Console.WriteLine($"{d} + {d1} = {func(d, d1)}");

        }

        private static void PerformOperation(double d, double d1, Operation operation) => operation(d, d1);

        private static double Divide(double a, double b) => a / b;

        private static double Multiply(double a, double b) => a * b;

        private static double Substract(double a, double b) => a - b;

        private static double Add(double a, double b) => a + b;
    }
}