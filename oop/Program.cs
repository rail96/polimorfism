using System;
using System.Collections.Generic;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
           /* var someShapes = new List<Shape>
            {
                new Triangle(),
                new Circle(),
                new Rectangle()
            }; 

            foreach (var t in someShapes)
            {
                t.Draw();
            }


            DerivedWork derivedWork = new DerivedWork();
            Work work = (Work)derivedWork;
           // Work work = new Work();

            derivedWork.WriteWork();
            derivedWork.DoWork();

            work.WriteWork();
            work.DoWork();
            */
            Base a = new Base();
            a.Foo();
            a.Bar();

            Derived b = new Derived();
            b.Foo();
            b.Bar();

            Base c = b;
            c.Foo();
            c.Bar();

            Console.ReadKey();
        }
    }
}
