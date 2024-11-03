using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class ComplexNumber /*: Object*/
    {
        public int Re {  get; set; }
        public int Im { get; set; }

        public override string ToString() => $"{Re}{(Im < 0 ? "" : "+")}{Im}i";

        //public override bool Equals(object obj)
        //{
        //    //1. korak
        //    //if (obj is ComplexNumber) //is je operator
        //    //{
        //    //    //ComplexNumber other = (ComplexNumber)obj; //eksplicitno castanje
        //    //    ComplexNumber other = obj as ComplexNumber; //as operator
        //    //    return Re==other.Re && Im==other.Im;
        //    //}

        //    //2. korak
        //    //pojednostavi to
        //    //is i as operator spojite zadjeno
        //    if (obj is ComplexNumber other)
        //    {
        //        return Re== other.Re && Im==other.Im;
        //    }
        //    return false;
        //}

        //3. dio -ternary
        //public override bool Equals(object obj)
        //=> obj is ComplexNumber other ? Re==other.Re && Im==other.Im : false ;

        //4. jednostavniji
        public override bool Equals(object obj)
        => obj is ComplexNumber other && Re==other.Re && Im==other.Im;

        //ako upotribino Re.GetHashCode() + Im.GetHashCode(), onda
        //3+2i i 2+3i to bi njemu islo u isti koš
        public override int GetHashCode()=>Re.GetHashCode()*31/Im.GetHashCode();
        //upotreba prime brojeva!

        //overload operatora
        public static bool operator ==(ComplexNumber a, ComplexNumber b) 
            => a.Re==b.Re && a.Im==b.Im;
        //1. način
        //public static bool operator !=(ComplexNumber a, ComplexNumber b)
        //    => a.Re != b.Re && a.Im != b.Im;

        //2. način - kraće
        public static bool operator !=(ComplexNumber a, ComplexNumber b)
            => !(a == b);
    }
}
