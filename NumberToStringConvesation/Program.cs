using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToStringConvesation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            int num = 3421;
            Console.WriteLine("=" + num);
            
            int[] arr = SaperateNumberFromInput(num);

            Dispalay(arr);
            //DisplayinStringFormate(arr);

            //int length = arr.Length;

            //Console.WriteLine("=====");

            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write(arr[i]);
            //}
            Console.ReadKey();
        }

        static void Dispalay(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if ( i == 0 )
                {
                    str += SelectNumber(arr[i]) + "-ty thousand and ";
                }
                else if(i == 1)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }

                else if (i == 2)
                {
                    str += SelectNumber(arr[i]) + "-ty ";
                }
                else
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }

        static void DisplayinStringFormate(int[] arr)
        {
            int length = arr.Length;

            string formate = null;

            for (int i = 0; i < length; i++)
            {
                switch (length)
                {
                    case 1:
                         formate = SelectNumber(arr[i]);
                        break;

                    case 2:
                        formate += SelectNumber(arr[i]) + " ";
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Undefined!");
                        break;

                }

                Console.Write(arr[i]);
            }
        }


        static string SelectNumber(int num)
        {
            string str = null;

            switch (num)
            {
                case 1:
                    str = "one";
                    break;
                case 2:
                    str = "two";
                    break;
                case 3:
                    str = "three";
                    break;
                case 4:
                    str = "four";
                    break;
                case 5:
                    str = "five";
                    break;
                case 6:
                    str = "six";
                    break;
                case 7:
                    str = "seven";
                    break;
                case 8:
                    str = "eight";
                    break;
                case 9:
                    str = "nine";
                    break;

                default:
                    str = " ";
                    break;
            }
            return str;
        }

        static int[] SaperateNumberFromInput(int num)
        {
            int[] arr = new int[100];
            int vagSesh;
            int i = 0;

            while (num > 0)
            {
                vagSesh = num % 10;
                arr[i] = vagSesh;
                ++i;
                num = num / 10; 
            }

            int[] arr2 = new int[i];

            int length = arr2.Length, t = 0;

            for (int j = length - 1; j >= 0; j--)
            {
                arr2[t++] = arr[j];
            }
            
            return arr2;
        }
    }
}
