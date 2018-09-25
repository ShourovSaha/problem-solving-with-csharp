using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindrom
{
    class Program
    {
        public static int LongestPalindrome(string str)
        {
            int Longest = 0;
            List<int> l = new List<int>();
            int i = 0;
            int palLen = 0;
            int s = 0;
            int e = 0;
            while (i < str.Length)
            {
                if (i > palLen && str[i - palLen - 1] == str[i])
                {
                    palLen += 2;
                    i += 1;
                    continue;
                }
                l.Add(palLen);
                Longest = Math.Max(Longest, palLen);
                s = l.Count - 2;
                e = s - palLen;
                bool found = false;
                for (int j = s; j > e; j--)
                {
                    int d = j - e - 1;
                    if (l[j] == d)
                    {
                        palLen = d;
                        found = true;
                        break;
                    }
                    l.Add(Math.Min(d, l[j]));
                }
                if (!found)
                {
                    palLen = 1;
                    i += 1;
                }
            }
            l.Add(palLen);
            Longest = Math.Max(Longest, palLen);
            return Longest;
        }


        public static string FindMaxLengthPalindrome(string s)
        {
            string maxLengthPalindrome = "";

            if (s == null) return s;

            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    bool found = true;
                    for (int k = j; k < (len - j) / 2; k++)
                    {
                        if (s[k] != s[len - (k - j + 1)])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        if (len - j > maxLengthPalindrome.Length)
                            maxLengthPalindrome = s.Substring(j, len - j);
                    }

                    if (maxLengthPalindrome.Length >= (len - (i + j)))
                        break;
                }

                if (maxLengthPalindrome.Length >= (len - i))
                    break;
            }

            return maxLengthPalindrome;
        }


        private static int GetLongestPalindrome(string str)
        {
            int rightIndex = 0, leftIndex = 0;
            var x = "";
            string currentPalindrome = string.Empty;
            string longestPalindrome = string.Empty;
            for (int currentIndex = 1; currentIndex < str.Length - 1; currentIndex++)
            {
                leftIndex = currentIndex - 1;
                rightIndex = currentIndex + 1;
                while (leftIndex >= 0 && rightIndex < str.Length)
                {
                    if (str[leftIndex] != str[rightIndex])
                    {
                        break;
                    }
                    currentPalindrome = str.Substring(leftIndex, rightIndex - leftIndex + 1);
                    if (currentPalindrome.Length > x.Length)
                        x = currentPalindrome;
                    leftIndex--;
                    rightIndex++;
                }
            }
            return x.Length;
        }


        static string LargestPalindrome1(string input)
        {
            int longest = 0;
            int limit = input.Length;
            for (int i = 0; i < limit; i++)
            {
                for (int j = limit - 1; j > i; j--)
                {
                    string forStr = input.Substring(i, j - i);
                    string revStr = new string(forStr.Reverse().ToArray());
                    if (forStr == revStr && forStr.Length > longest)
                    {
                        return forStr;
                    }
                }
            }
            return "";
        }



        public static int LongestPalindrome111(string str)
        {
            var longest = 0;
            var start = -1;

            for (int i = 0; i < str.Length - longest / 2; i++)
            {
                // odd                 
                var gap = 1;
                while (i - gap >= 0 && i + gap < str.Length && str[i - gap] == str[i + gap])
                {
                    gap++;
                }

                if (longest < 1 + (gap - 1) * 2)
                {
                    longest = 1 + (gap - 1) * 2;
                    start = i - gap + 1;
                }
                // even                 
                gap = 0;
                while (i - gap >= 0 && i + 1 + gap < str.Length && str[i - gap] == str[i + 1 + gap])
                {
                    gap++;
                }

                if (longest < gap * 2)
                {
                    longest = gap * 2;
                    start = i - gap + 1;
                }
                gap = 0;
                while (i - 1 - gap >= 0 && i + gap < str.Length && str[i - 1 - gap] == str[i + gap])
                {
                    gap++;
                }

                if (longest < gap * 2)
                {
                    longest = gap * 2;
                    start = i - gap - 1;
                }
            }

            return str.Substring(start, longest).Length;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int result = LongestPalindrome111(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
