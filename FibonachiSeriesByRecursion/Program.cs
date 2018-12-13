using System;

namespace FibonachiSeriesByRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int ip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===============");
            int[] a = FibonacheeSeries(ip);

            for (int i = 0; i <= ip - 1; i++)
            {
                Console.Write(a[i] + "-->");
            }

            Console.ReadKey();
        }

        static int[] FibonacheeSeries(int len)//By loop
        {
            int[] a = new int[len];
            a[0] = 0;
            a[1] = 1;

            for (int i = 2; i <= len - 1; i++)
            {
                a[i] = a[i - 1] + a[i - 2];
            }

            return a;
        }
    }
}
