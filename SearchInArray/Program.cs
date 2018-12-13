using System;

namespace SearchInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 5, 4, 1, 10, 7, 3};

            foreach (int c in arr)
            {
                Console.Write(c + "-->");
            }
            Console.WriteLine();

            int result = IsFound(arr);
            if (result == -1)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine("Index:" + result);
            }
            Console.ReadKey();
        }

        static int IsFound(int[] arr)
        {
            int index = -1;
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                if (SumOfLeft(arr, i - 1) == SumOfRight(arr, i + 1))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static int SumOfLeft(int[] arr, int index)
        {
            int total = 0;
            if (index == 0)
            {
                return total = arr[index];
            }
            for (int i = 0; i <= index; i++)
            {
                total += arr[i];
            }
            return total;
        }

        static int SumOfRight(int[] arr, int index)
        {
            int total = 0;
            if (index == arr.Length - 1)
            {
                return total = arr[index];
            }
            for (int i = index; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }
    }
}
