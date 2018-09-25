//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReverseString2
//{
//    interface aa
//    {
//        int dd(ref int x);
//        void dd();

//    }

//    class fun
//    {

//    }
//    class Program
//    {
//        string fun = "aefa";
//        string s = fun;
        
//        static char[] tempIp = new char[10];
//        static string[] strArr = new string[20];
//        static void Main(string[] args)
//        {
//            string[] ip = { "I eat rice" };
//            char[] charIp = ip[0].ToArray();
//            for(int i = 0; i < charIp.Length; i++)
//            {
//                if(charIp[i] == ' ')
//                {
//                    func1(ref charIp, i);
                    
//                }
//                //Console.WriteLine(charIp[i]);
//                //Console.WriteLine("====");
//            }

//            print();

//            Console.ReadKey(); 
//        }

//        static void func1(ref char[] charIp, int index)
//        {
//            int i = 0;
//            for (; i < index; i++)
//            {
//                tempIp[i] = charIp[i];
//                //Console.Write(tempIp[i]);
//            }
//            strArr[i] = tempIp.ToString();
//            return;
//        }

//        static void print()
//        {
//            for (int i = tempIp.Length; i <= 0 ; i--)
//            {
//                Console.Write(tempIp[i]);
//            }
//        }
//    }
//}
