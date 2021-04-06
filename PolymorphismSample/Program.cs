using System;

namespace PolymorphismSample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Square square = new Square();          
            square.Draw();
            Console.WriteLine("Square area : " + square.Area());
            Console.WriteLine("Square circumference : " + square.Circumference());

            Console.WriteLine("\n");

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            Console.WriteLine("Square area : " + rectangle.Area());
            Console.WriteLine("Square circumference : " + rectangle.Circumference());

            Console.ReadLine();
        }
    }
}
