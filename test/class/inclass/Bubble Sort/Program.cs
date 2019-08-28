using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10] { 5, 1, 4, 2, 7, 3, 8, 6, 9, 0 };
            Console.WriteLine("Mang truoc khi sap xep :"+ string.Join(",",A));
            
            BubbleSort(A);
            Console.Write("Mang sau khi sap xep: "+string.Join(",",A));
        }

        public static void BubbleSort(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array.Length -1- i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

