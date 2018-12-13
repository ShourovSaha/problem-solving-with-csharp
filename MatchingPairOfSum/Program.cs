using System;

namespace MatchingPairOfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string testInput = Convert.ToString(Console.ReadLine().Trim());
            //int[] testArray = new int[100];
            //string str = testInput.Trim();


            //for (int i = 0; i < str.Length; i++)
            //{
            //    testArray[i] = Convert.ToInt32(testInput[i]);
            //}

            int[] testArray = { 9, 4, 5, 1 };

            Console.WriteLine("Input Test Sum :");
            int sum = Convert.ToInt32(Console.ReadLine());

            if(IsFound(sum, testArray))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }

        //static bool IsFound(int sum, int[] arrays)//O(n2)
        //{
        //    bool result = false;

        //    for (int i = 0;  i < arrays.Length; i++)
        //    {
        //        for (int j = 0; j < arrays.Length; j++)
        //        {
        //            if (j != i)
        //            {
        //                if (arrays[i] + arrays[j] == sum)
        //                {
        //                    result = true;
        //                }
        //            }

        //        }
        //    }
        //    return result;
        //}

        static bool IsFound(int sum, int[] arrays)//O(n2)
        {
            bool result = false;
            int mid = arrays.Length / 2;

            int front = 0;
            int end = arrays.Length - 1;

            for (int i = 0; i < mid; i++)
            {
                if (arrays[front] + arrays[end] == sum)
                {
                    result = true;
                }
                ++front;
                --end;
            }
            return result;
        }
    }
}
