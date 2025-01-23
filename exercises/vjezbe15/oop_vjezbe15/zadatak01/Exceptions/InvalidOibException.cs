using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak01.Exceptions
{
    [Serializable]

    internal class InvalidOibException: Exception
    {
        public InvalidOibException() : base("OIB mora imati 11 znakova!") { }
        public InvalidOibException(string message): base(message) { }
    }
}
