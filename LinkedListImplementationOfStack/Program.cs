using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementationOfStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 0;
            int n = Convert.ToInt16(Console.Read());
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr2[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr3[i] = arr[i] + arr2[i];
                Console.Write(arr3[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
