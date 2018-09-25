using ExtendionMethod.CustomClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendionMethod.CustomClass2
{
    static class SomeMoremath
    {
        //public MyMath myMath = new MyMath();
        public static int Subtruction(this MyMath myMathObj, int n1, int n2)
        {
            return n1 - n2;
        }

    }
}
