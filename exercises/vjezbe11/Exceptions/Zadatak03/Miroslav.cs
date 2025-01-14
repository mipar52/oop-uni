using System;

namespace Zadatak03
{
    public class Miroslav: IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}