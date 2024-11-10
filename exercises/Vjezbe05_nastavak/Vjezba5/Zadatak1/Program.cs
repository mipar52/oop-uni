using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inicijalizacija objekta
            ComplexNumber cn1= new ComplexNumber 
            {
                Re=3,
                Im=3
            };
            Console.WriteLine(cn1);

            ComplexNumber cn2 = new ComplexNumber
            { 
                Re=3, Im=2
            };
            Console.WriteLine(cn2);

            Console.WriteLine(cn1==cn2);// == oprator upoređuje reference (overloadali smo ga)
            //cn1=cn2; -> cn1 se refentira na cn2, ukoliko su uvjeti istiniti onda je sve bez izmjene

            Console.WriteLine(cn1.Equals(cn2));
            //equals isto uspoređuje reference - i njega smo overriden radili
            }
    }
}
