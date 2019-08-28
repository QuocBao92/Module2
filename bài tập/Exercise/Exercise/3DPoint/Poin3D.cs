using System;
using System.Collections.Generic;
using System.Text;

namespace _3DPoint
{
    class Poin3D
    {
        private float z;
        private float x;
        private float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }

        public void MoveTo(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Poin3D(float x, float y, float z)
        {
            MoveTo(x, y, z);
        }
        public double DistanceTo(Poin3D p2)
        {
            return Math.Sqrt((x - p2.X * x - p2.X) + (y - p2.Y * y - p2.Y) + (z - p2.Z * z - p2.Z));
        }

        public override string ToString()
        {
            return "(" + x + " - " + y + "-" + z + ")";
        }
    }
}
