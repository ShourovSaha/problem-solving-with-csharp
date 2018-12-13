using System;

namespace DecimalToBinary
{
    class Program
    {
        static int[] arr = new int[20]; 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int ip = Convert.ToInt16(Console.ReadLine());
            int bits = GetNumberofBit(ip);
            Console.WriteLine("bit :" + bits);
            Console.WriteLine();
            
            for (int i = 0; i < bits ; i++)
            {
                Console.Write(arr[bits  - i] + " ");
            }
            Console.ReadKey();
        }

        static int GetNumberofBit(int n)
        {
            int i = 0, count = 0;
            while (n > 0)
            {
                arr[++i] = n % 2;
                ++count;
                n /= 2;
            }

            return count;
        }
    }
}
