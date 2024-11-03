using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Point
    {
        private int x; private int y;

        public int X 
        { 
            get 
            { return x; } 
            set 
            { x = value; } 
        }
        public int Y { get { return y; } set { y = value; } }

        public Point() { }
        public Point(int x, int y)
        {

            X= x; Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
