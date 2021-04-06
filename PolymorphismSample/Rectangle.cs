using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSample
{
    class Rectangle:Shape
    {
        double height = 7 , weight =5;

        public override void Draw()
        {
            Console.WriteLine("Rectangle was drawn");
        }
        public override double Area()
        {
            return weight * height;
        }

        public override int Circumference()
        {
            return 2 * (int)(weight + height);
        }
    }
}
