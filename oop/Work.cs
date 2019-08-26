using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Work
    {
        public virtual void WriteWork()
        {
            Console.WriteLine("base class");
        }
        public virtual int DoWork()
        {
            return 0;
        }
    }

    public class DerivedWork : Work
    {
        public new void WriteWork()
        {
            Console.WriteLine("derivedWork class");
        }
        public new int DoWork()
        {
            return 1;
        }
    }
}
