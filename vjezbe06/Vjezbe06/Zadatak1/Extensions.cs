using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    // klasa mora biti static!
    static class Extensions
    {
        // metoda mora biti static
        // prvi parametar mora definirati tip podatka na kojem se dodaje metoda extension
        public static string Format(this int value, string mesaturement)
        {
            return $"{value} {mesaturement}";
        }
    }
}
