using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class ClassLib
    {
        public static int counter = 0;

        public void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Foo);
            ThreadPool.QueueUserWorkItem(Foo);
        }

        public void Foo(Object bar)
        {
            Console.WriteLine(Interlocked.Increment(ref counter));
        }
    }
}
