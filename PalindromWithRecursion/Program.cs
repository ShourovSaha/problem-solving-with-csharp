using System;

namespace PalindromWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrom");
            string ip = "madam";
            int head = 0;
            int tail = ip.Length - 1;

            //string str = IsPalindrom(ip) == true ? "yes" : "no";

            string str = IsPalindrom(ip, head, tail) == true ? "yes" : "no";
            Console.WriteLine("Ans: " + str);
            Console.ReadKey();
        }


        static bool IsPalindrom(string str, int head, int tail)//By recursion
        {
            if (head > tail)
            {
                return true;
            }

            if (str[head] != str[tail])
            {
                return false;
            }

            return  IsPalindrom(str, ++head, --tail);
        }

        static bool IsPalindrom(string str)//by looping 
        {
            bool result = false;
            char[] charArr = str.ToCharArray();
            int length = charArr.Length;
            int head = 0;
            int tail = length - 1;

            if (str.Length == 1)
            {
                return true;
            }

            while (head <= tail)
            {
                if (charArr[++head] != charArr[--tail])
                {
                    return false;
                }
                result = true;
            }
            return result;
        }
    }
}
