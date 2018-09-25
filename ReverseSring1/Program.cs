//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ReverseSring1
//{
    
//    class Program
//    {
//        //char[] w1, w2;
//        char[] ip = new char[20];
//        static void Main(string[] args)
//        {
//            int spaceCount = 0;

           
//            ip = "Cats and dogs".ToArray();

//            for(int i = 0; i < ip.Length; i++)
//            {
//                if (ip[i].ToString() == " ")
//                {
//                    spaceCount += 1;
//                    if(spaceCount == 1)
//                    {
//                        reverse1stWord(ref ip, i);
//                    }
//                    else if(spaceCount < 1)
//                    {
//                        reverse2ndWord(ref ip, i);
//                    }
//                }
//                //Console.Write(ip[i]);
//            }
//            Console.ReadKey();
//        }

//        char[] reverse1stWord(ref char[] w, int n)
//        {
//            char[] temp = new char[n]; 
//            for (int i = 0; i < n; i++)
//            {
//                temp[i] = w[i];
//            }

//            for (int i = w.Length - n;  i < w.Length; i++ )
//            {
                
//                w[i] = temp[i - x];
//                x++; 
//            }
//            return;
//        }

//        char[] reverse2ndWord(ref char[] w2, int i)
//        {
//            return
//        }
//    }
//}
