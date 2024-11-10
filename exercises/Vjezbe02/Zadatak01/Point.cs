using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak01
{
    internal class Point
    {
        private int x;
        private int y;
        
        public int X
        { 
            get { return x; } // ovo je isto kao i { get; set; }
            set { x = value; } 
        }

        public int Y { 
            get { return y; } 
            set { y = value; } 
        }

        public Point() { } // default konstruktor - ovo se ne mora ni napisati

        public Point(int x, int y) // custom konstruktor
        {
            X = x;
            Y = y;
        }

        public override string ToString() // ova metoda sluzi da se override-a, slicno kao i description u swiftu
        {
            return $"({X}, {Y})";

        }
    }
}
