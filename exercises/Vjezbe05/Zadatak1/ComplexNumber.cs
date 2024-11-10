using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class ComplexNumber
    {
        public int RealniDio {  get; set; }
        public int ImaginarniDio { get; set; }
        public override string ToString() => $"{RealniDio}{(ImaginarniDio < 0 ? "" : "+")}{ImaginarniDio}i";


        /*
         * 
         *         public override bool Equals(object obj)
    {
        // 1. korak
        if (obj is ComplexNumber) 
        { 
            // ComplexNumber other = (ComplexNumber)obj; // eksplicitno castanje
            ComplexNumber other2 = obj as ComplexNumber; // 
            return RealniDio == other2.RealniDio && ImaginarniDio == other2.ImaginarniDio;
        }

        // 2. korak
        // pojednostavi to
        // is i as operator spojite zajedno

         * if (obj is ComplexNumber other) 
           {
            return RealniDio == other.RealniDio && ImaginarniDio == other.ImaginarniDio;
            }
                    return false;

        // 3. dio - ternary operator
       //  => obj is ComplexNumber other ? RealniDio = other.RealniDio && ImaginarniDio == other.ImaginarniDio : false;

        // 4. dio 
        => obj is ComplexNumber other ? RealniDio == other.RealniDio && ImaginarniDio == other.ImaginarniDio;

    }
         */



        /* Note ako se overridea Equals, moras i HashCode overridati 
         * ako upotrijebimo Re.GetHashCode() + Im.getHashCode() -> 3+2i i 2+3i to bi njemu islo u isti kos*/
        public override bool Equals(object obj)
        {
            return obj is ComplexNumber other ? RealniDio == other.RealniDio && ImaginarniDio == other.ImaginarniDio : false;
        }

        public override int GetHashCode() => RealniDio.GetHashCode() * 31 / ImaginarniDio.GetHashCode();

        // overload operatora -> da == radi, moras i overloadati i !=
        public static bool operator == (ComplexNumber left, ComplexNumber right) => left.RealniDio == right.RealniDio && left.ImaginarniDio == right.ImaginarniDio;

        // 1. nacin
        public static bool operator != (ComplexNumber left, ComplexNumber right) { return !(left.RealniDio != right.RealniDio && left.ImaginarniDio != right.ImaginarniDio); }


    }
}
