using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWiseDuplicationCheckInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0, 2, 1, 3, 2 };

            Console.WriteLine("Duplicate number: " +  DuplicateCheck(array));
            Console.ReadKey();
        }

        static int DuplicateCheck(int[] array)
        {
            int sum = 0;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (array[i] < 0 || array[i] > length - 2)
                {
                    throw new Exception("Invalid number!");
                }

                sum += array[i];
            }

            int sum2 = (length - 1) * (length - 2) >> 1;

            return sum - sum2;
        }
    }
}
