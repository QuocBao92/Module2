using System;

namespace test_Rectangle
{
        class Rectangle
        {
            double length;
            double width;
    
        public void Accepdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double getArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("chiều dài là : " + length);
            Console.WriteLine("chiều rộng là : " + width);
            Console.WriteLine("Diện tích là: " + getArea());
        }
    }
}
