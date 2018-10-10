using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,]arr = new int[3,5]{ { 5, 12, 17, 9, 3 }, { 13, 4, 8, 14, 1 }, { 9, 6, 3, 7, 21 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
