using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiltipleDuplicateInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 1, 0, 2, 5, 3 };

            PrintMultipleDuplicateNumber(array);

            Console.Read();
        }

        static void PrintMultipleDuplicateNumber(int[] array)
        {
            int count = 0;
            List<int> duplicateNumbers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                //if (array[i] < 0 || array.Length > array[i])
                //{
                //    throw new Exception("Invalid number");
                //}

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        duplicateNumbers.Add(array[j]);
                        ++count;
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine("Duplicate number: ");
                PrintDuplicateNumbers(duplicateNumbers);
            }
            else
            {
                Console.WriteLine("No Duplicate number!!");
            }
        }

        static void PrintDuplicateNumbers(List<int> duplicateNumbers)
        {
            foreach (int num in duplicateNumbers)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
