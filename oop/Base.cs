using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class Base
    {
        public virtual void Foo()
        {
            Console.WriteLine("I'm a Foo method in class Base");
        }
        public void Bar()
        {
            Console.WriteLine("I'm a Bar method in class Base");
        }
    }

    class Derived : Base
    {
        public override void Foo()
        {
            Console.WriteLine("I'm a Foo method in class Derived");
        }
        new public void Bar()
        {
            Console.WriteLine("I'm a Bar method in class Derived");
        }
    }

    /* class Test
     {
         static void Main(string[] args)
         {
             Base a = new Base();
             a.Foo(); //"I'm a Foo method in class Base"
             a.Bar(); //I'm a Bar method in class Base"

             Derived b = new Derived();
             b.Foo();  //"I'm a Foo method in class Derived"
             b.Bar();  //I'm a Bar method in class Derived

             Base c = b;
             c.Foo();  //"I'm a Foo method in class Derived"
             c.Bar();  //I'm a Bar method in class Base
         }
     }
     */
}
