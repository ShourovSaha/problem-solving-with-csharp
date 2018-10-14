using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int arrayLength = int.Parse(Console.ReadLine());
            //int arrayRotation = int.Parse(Console.ReadLine());

            //int[] arr = new int[arrayLength];

            string[] array1 = Console.ReadLine().Split(' ');

            int arrayLength = Convert.ToInt32(array1[0]);
            int arrayRotation = Convert.ToInt32(array1[1]);

            int[] arrayInput = Array.ConvertAll(Console.ReadLine().Split(' '), temp => Convert.ToInt32(temp));

            LeftRotate(arrayInput, arrayLength, arrayRotation);

            PrintArray(arrayInput);


            Console.ReadKey();
        }

        static int[] LeftRotate(int[] arr, int arrayLength, int arrayRotation)
        {
            if (arrayLength < arrayRotation)
            {
                arrayRotation = arrayRotation % arrayLength;
            }

            for (int i = 0; i < arrayRotation; i++)
            {
                int temp = arr[0];

                for (int j = 0; j < arrayLength; j++)
                {
                    if (j < arrayLength - 1)
                    {
                        arr[j] = arr[j + 1];
                    }
                    else if(j == arrayLength - 1)
                    {
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
