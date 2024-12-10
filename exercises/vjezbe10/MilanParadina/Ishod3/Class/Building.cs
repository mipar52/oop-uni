using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ishod3.Class
{
    internal class Building: IBuildable
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }

        public Building(double height, double width, double lenght)
        {
            Height = height;
            Width = width;
            Lenght = lenght;
        }

        public override string ToString() => $"Building info:\nHeight: {this.Height}, Width: {this.Width}, Lenght: {this.Lenght}";

        public void build()
        {
            Console.WriteLine("Building the building...");
            Console.WriteLine("..");
            Console.WriteLine("..");
            Console.WriteLine("..");
            Console.WriteLine($"Built the building!!\n{this.ToString()}\n");
        }
    }
}
