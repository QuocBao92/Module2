using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class test2
    {
        public static void Main()
        {
            int[] arr = new[] { 0, 1, 2, 3, 4 };
            int z = arr.Length;
            //int last = arr.Length - 1;
            Console.WriteLine(string.Join(",", arr));

            for (int i = 0; i < arr.Length/2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[z - 1 - i];
                arr[z - 1 - i] = temp;
            }
               
            
           
                Console.WriteLine(string.Join(",",arr));
               // Console.Read();
            
        }
    }
}
