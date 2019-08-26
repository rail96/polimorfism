using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing base shape");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle shape");
            base.Draw();
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle shape");
            base.Draw();
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle shape");
            base.Draw();
        }
    }

}
