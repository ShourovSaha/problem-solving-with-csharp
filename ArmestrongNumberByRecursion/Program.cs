using System;
using System.Collections.Generic;

namespace ArmestrongNumberByRecursion // Fibonachee Series :[0,1,1,2,3,5,8,...]
{
    class Program
    {
        //static List<int> list = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int ip = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("===============");
            int[] a = FibonacheeSeries(ip);

            for (int i = 0; i <= ip - 1; i++)
            {
                Console.Write(a[i] + "-->");
            }

            Console.ReadKey();
        }

        //[0,1,1,2,3,5,8,...]
        //static int[] FibonacheeSeriesByRecursion(int len)
        //{
        //    int[] a = new int[len];
        //    a[0] = 0;
        //    a[1] = 1;
        //    if (len == len - 1)
        //        return;

        //}

        //[0,1,1,2,3,5,8,...]
        //static int[] FibonacheeSeries(int len)
        //{
        //    int[] a = new int [len];
        //    a[0] = 0;
        //    a[1] = 1;

        //    for (int i = 2; i <= len - 1; i++)
        //    {
        //        a[i] = a[i - 1] + a[i - 2]; 
        //    }

        //    return a;
        //}
    }
}
