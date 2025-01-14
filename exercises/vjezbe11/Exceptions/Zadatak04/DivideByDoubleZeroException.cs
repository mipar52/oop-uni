using System;

namespace Zadatak04
{
    public class DivideByDoubleZeroException: Exception
    {
        public DivideByDoubleZeroException(): base("Divide by zero")
        {
        }
    }
}