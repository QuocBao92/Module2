using System;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] B = new int[] { 0, 5, 3, 7, 8, 1, 6, 4, 5 };
           
            Console.WriteLine("sum array {0} is {1}", string.Join(",",B), Sumarray(B,B.Length));
        }

        public static int Sumarray(int[] aray, int n)
        {
            if (n == 1)
                return aray[n-1];
            return aray[n - 1] + Sumarray(aray, n - 1);
        }
    }
}
