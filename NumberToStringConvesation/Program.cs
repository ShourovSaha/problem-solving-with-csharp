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
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("=" + num);

            int[] arr = SaperateNumberFromInput(num);
            DisplayinStringFormate(arr);


            //int num = 3421;
            //Dispalay(arr);


            Console.ReadKey();
        }

        static void DisplayinStringFormate(int[] arr)//display for dynamic input
        {
            int length = arr.Length;

            string formate = null;

            switch (length)
            {
                case 1:
                    formate += SelectNumber(arr[0]);
                    Console.WriteLine(formate);
                    break;

                case 2:
                    DispalayForDoshok(arr);
                    break;

                case 3:
                    DispalayForHurndred(arr);
                    break;

                case 4:
                    DispalayForThousand(arr);
                    break;

                case 5:
                    DispalayForOjut(arr);
                    break;

                case 6:
                    DispalayForLak(arr);
                    break;

                case 7:
                    DispalayForNijut(arr);
                    break;

                case 8:
                    DispalayForCror(arr);
                    break;

                default:
                    Console.WriteLine("Undefined!");
                    break;

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

        static string SelectNumberDifferenrNumberSpalling(int num)
        {
            string str = null;
            switch (num)
            {
                case 2:
                    str = "twen";
                    break;
                case 3:
                    str = "thir";
                    break;
                case 4:
                    str = "for";
                    break;
                case 5:
                    str = "fif";
                    break;
                case 8:
                    str = "eigh";
                    break;
                default:
                    break;
            }
            return str;
        }

        static void DispalayForDoshok(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                    
                }
                else if (i == 1)
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }


        static void DispalayForHurndred(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }
                else if (i == 1)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 2)
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }

        static void DispalayForThousand(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    str += SelectNumber(arr[i]) + " thousand and ";
                }
                else if (i == 1)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }

                else if (i == 2)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
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

        static void DispalayForOjut(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }
                else if (i == 1)
                {
                    str += SelectNumber(arr[i]) + " thousand and ";
                }

                else if (i == 2)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }

                else if (i == 3)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 4)
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }

        static void DispalayForLak(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    str += SelectNumber(arr[i]) + " lak ";
                }
                else if (i == 1)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 2)
                {
                    str += SelectNumber(arr[i]) + " thousand and ";
                }

                else if (i == 3)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }

                else if (i == 4)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 5)
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }

        static void DispalayForNijut(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }
                else if (i == 1)
                {
                    str += SelectNumber(arr[i]) + " lak and ";
                }

                else if (i == 2)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 3)
                {
                    str += SelectNumber(arr[i]) + " thousand and";
                }

                else if (i == 4)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }

                else if (i == 5)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 6)
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }


        static void DispalayForCror(int[] arr)
        {
            string str = null;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    str += SelectNumber(arr[i]) + " cror and ";
                }
                else if (i == 1)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 2)
                {
                    str += SelectNumber(arr[i]) + " lak and ";
                }

                else if (i == 3)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 4)
                {
                    str += SelectNumber(arr[i]) + " thousand and ";
                }

                else if (i == 5)
                {
                    str += SelectNumber(arr[i]) + " hurndred and ";
                }

                else if (i == 6)
                {
                    if (arr[i] == 2 || arr[i] == 3 || arr[i] == 4 || arr[i] == 5 || arr[i] == 8)
                    {
                        str += SelectNumberDifferenrNumberSpalling(arr[i]) + "ty ";
                    }
                    else if (arr[i] == 1)
                    {
                        str += SelectNumber(arr[i]);
                    }
                    else
                    {
                        str += SelectNumber(arr[i]) + "ty ";
                    }
                }

                else if (i == 7)
                {
                    str += SelectNumber(arr[i]);
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine(str);
            Console.WriteLine("=========================");
        }
    }
}
