using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishod3.Class
{
    internal class Computer: IBuildable
    {
        public int HddSize { get; set; }
        public int MemorySize { get; set; }

        public Computer(int hddSize, int memorySize)
        {
            this.HddSize = hddSize;
            this.MemorySize = memorySize;
        }

        public override string ToString() => $"Computer info:\nHDD size: {this.HddSize}, Memory size: {this.MemorySize}";

        public void build()
        {
            Console.WriteLine("Building the computer...");
            Console.WriteLine("..");
            Console.WriteLine("..");
            Console.WriteLine("..");
            Console.WriteLine($"Built the computer!!\n{this.ToString()}\n");
        }
    }
}
