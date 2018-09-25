using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendionMethod.CustomClass;
using ExtendionMethod.CustomClass2;

namespace ExtendionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath mathObj = new MyMath();
            int x = mathObj.Add(10, 20);
            Console.WriteLine(x);

            x = mathObj.Subtruction(200, 100);
            Console.WriteLine(x);

            //SomeMoremath o1 = new SomeMoremath();
            //x = o1.myMath.Add(100, 20);
            //Console.WriteLine(x);

            //x = o1.Subtruction(300, 50);
            //Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
