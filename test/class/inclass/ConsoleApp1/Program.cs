using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("giai thua cua {0} la {1}",n,GiaiThua(n));
        }
        public static long GiaiThua(int n)
        {
            if (n > 0)
            {
                if (n == 1)
                    return 1;
                return n * (GiaiThua(n - 1));
            }
            return -1;
        }
    }
}
