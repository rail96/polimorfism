using System;
using System.Collections.Generic;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var someShapes = new List<Shape>
            {
                new Triangle(),
                new Circle(),
                new Rectangle()
            }; 

            foreach (var t in someShapes)
            {
                t.Draw();
            }
            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
