using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
   public class Door
    {
        protected string color;
        public Door()
        {
            Color = "brown";
        }
        public Door(string color)
        {
            this.Color = color;
        }

        public string Color { get => color; set => color = value; }
        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}.", color);
        }
    }
}
