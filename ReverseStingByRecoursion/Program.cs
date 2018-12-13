using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStingByRecoursion
{
    class Program
    {
        static char[] newArr = new char[10]; 
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            ReverseString("abc", 0);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void ReverseString(string s, int i)
        {
            if (i == s.Length - 1)
            {
               //newArr[s.Length - i] = s[i];
                Console.Write(s[i]);
                return;
            }

            ReverseString(s, i + 1);
            //newArr[s.Length - i] = s[i];
            Console.Write(s[i]);
        }
    }
}
