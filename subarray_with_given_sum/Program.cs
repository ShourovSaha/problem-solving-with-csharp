namespace subarray_with_given_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int N = 5, S = 12;
            int[] A = { 1, 2, 3, 7, 5 };
            Solution solution = new Solution();

            var result = solution.subarraySum(A, N, S);

            result.ForEach(item => Console.Write(item + " "));

            Console.ReadKey();

        }
    }


    internal class Solution
    {
        //Function to find a continuous sub-array which adds up to a given number.
        public List<int> subarraySum(int[] arr, int n, int s)
        {
            //code here
            List<int> result = new List<int>();
            int sumOfNumber = 0;
            int stratPointer = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumOfNumber += arr[i];
                if (sumOfNumber == s)
                {
                    result.Add(stratPointer);
                    result.Add(arr[i]);
                }
                else if(sumOfNumber > s)
                {
                    sumOfNumber -= arr[stratPointer];
                    ++stratPointer;
                }
            }

            if (sumOfNumber != s) result.Add(-1);

            return result;
        }

    }
}