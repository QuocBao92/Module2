using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = true;
            var mySmallApartment = new SmallApartment();
            var myPerson = new Person();

            myPerson.Name = "Bao";
            myPerson.House = mySmallApartment;
            myPerson.House.Door.Color = "yellow";
            myPerson.ShowData();
            if (debug)
                Console.ReadLine();
        }
    }
}
