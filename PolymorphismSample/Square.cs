using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSample
{
    class Square:Shape
    {
        double edge = 5;
        public override void Draw()
        {
            Console.WriteLine("Square was drawn");
        }

        public override double Area()
        {         
            return edge * edge;
        }

        public override int Circumference()
        {
            return (int)edge * 4;
        }
    }
}
