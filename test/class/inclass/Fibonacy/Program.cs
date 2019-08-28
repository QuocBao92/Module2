using System;

namespace Fibonacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fibonacy thu  {0} la {1}", n, Fibonacy(n));

            
        }
        public static long Fibonacy(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonacy(n - 1) + Fibonacy(n - 2);
        }
    }
}
