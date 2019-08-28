using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10] { 5, 1, 4, 2, 7, 3, 8, 6, 9, 0 };

            //Console.WriteLine("Mang truoc khi sap xep :" + string.Join(",", A));
            //Console.WriteLine("Selection Sort Running-----------");
            //SelectionSort(A);

            //Console.WriteLine("Insert Sort Running-----------");
            //InsertionSort(A);
            //Console.Write("Mang sau khi sap xep: " + string.Join(",", A));

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("tim kiem nhi phan");
            SelectionSort(A);
            Console.WriteLine("Array :" + string.Join(",", A));
            
            Console.Write("input number find: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("vi tri cua so {0} trong mang la :{1} ",num,Find_NhiPhan(A,num)+1);
        }
        public static void InsertionSort(int[]array)
        {
            int value;
            int j;
            for (int i = 1;i< array.Length; i++)
            {
                value = array[i];
                j = i-1;
                while(j>=0 && array[j] > value)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }

        public static void SelectionSort(int[] array)
        {
            int temp, min;
            for (int i = 0; i < array.Length-1; i++)
            {
                min = i;
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;

                }
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }

        //public static void QuickSort()
        //{
        //    int temp, mid;
        //    mid = 
        //}

        public static int Find_NhiPhan(int[]array, int target)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid = 0;
            while (min<= max)
            {
                mid = (min + max) / 2;
                if(array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    min = mid + 1;
                }else
                {
                    max = mid - 1;
                }
            }
            return -1;
        }

    }
}
