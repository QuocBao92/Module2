using System;

namespace _3DPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Poin3D[] poins = new Poin3D[5];
            poins[0] = new Poin3D(5, 7, -2);
            poins[1] = new Poin3D(1, -5, 1);
            poins[2] = new Poin3D(-3, 0, -1);
            poins[3] = new Poin3D(4, 4, 2);
            poins[4] = new Poin3D(2, -3, 1);
            for(int i = 0; i < poins.Length-1; i++)
            {
                Console.WriteLine("Distance p{0} and p{1} is : {2} " ,i+1,i+2, poins[i].DistanceTo(poins[i+1]));
            }
           
        }
    }
}
