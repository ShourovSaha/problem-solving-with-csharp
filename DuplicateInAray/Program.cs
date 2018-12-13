using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateInAray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 2, 1, 3, 2};

            PrintDuplicateNumber(array);

            Console.Read();
        }

        static void PrintDuplicateNumber(int[] array)
        {
            int count = 0;
            int num = 0;
            //int[] duplicateNumberPosition; 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        num = array[j];
                        ++count;
                        break;
                    }
                    
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Duplicate number: " + num);
            }
            else
            {
                Console.WriteLine("No Duplicate number!!");
            }            
        }
    }
    
}
