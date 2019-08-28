using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public class Person
    {
        private string name;
        private House house;

        public string Name { get => name; set => name = value; }
        public House House { get => house; set => house = value; }

        public Person()
        {
            Name = "Bao";
            House = new House(150);
        }
        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
        public void ShowData()
        {
            Console.WriteLine("My house is {0}",name);
            house.ShowData();
            house.Door.ShowData();
        }
    }
}
