using System;

namespace Recursion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int ip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("============");
            Console.WriteLine(Total(ip));

            Console.ReadKey();
        }


        //static int[] Fibonachi(int l)
        //{
        //    int[] arr = new int[l];

        //    for (int i = 0; l < l - 1; i++)
        //    {
        //        arr[i] = arr[i];
        //        arr[i + 1] = arr[i + ];
        //    }
        //}


        static int Factorial(int f)
        {
            int total;

            if (f == 1)
            {
                return 1;
            }
            else
            {
                total = f * Factorial(f - 1);
            }

            return total;
            //return total = f == 1 ? 1 : f * Factorial(f - 1); 
        }
        

        static int Total(int x)
        {
            int total;
            if (x == 0)
                return x;

            Console.Write(x + "-->");
            return total = x + Total(x - 1);
        }
    }
}
