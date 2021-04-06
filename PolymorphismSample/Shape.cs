using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSample
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("The shape was drawn");
        }

        public virtual double Area()
        {
            return 0;
        }
        public virtual int Circumference()
        {
            return 0;
        }

    }
}
