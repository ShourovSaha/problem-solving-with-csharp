using System;

namespace WaterTank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(SmallJar(2, 2, 55));

            Console.ReadKey();
        }

        static int SmallJar(int smallJar, int bigJar, int waterLitter)
        {
            int available = waterLitter;
            int count = 0;

            while (waterLitter >= 20 && bigJar != 0)
            {
                available -= 20;
                --bigJar;
            }

            if (smallJar > 0)
            {
                count = (available % 5) + (available / 5);

                if (count <= smallJar)
                {
                    return count;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
