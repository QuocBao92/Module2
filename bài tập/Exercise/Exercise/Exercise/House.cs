using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    public class House
    {
        private float area;
        private Door door;
        public House(float are)
        {
            this.area = are;
            Door = new Door();
        }
        
        

        public float Area { get => area; set => area = value; }
        public Door Door { get => door; set => door = value; }

        public virtual string ShowData()
        {
            return $"I am a house, my are is {Area} m2";
        }
    }
}
