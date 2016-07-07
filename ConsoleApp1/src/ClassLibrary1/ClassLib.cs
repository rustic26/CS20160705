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

        public static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Foo);
            ThreadPool.QueueUserWorkItem(Foo);

            Console.WriteLine("Hello World.");
            Console.ReadKey();
        }

        public static void Foo(Object bar)
        {
            Console.WriteLine(Interlocked.Increment(ref counter));
        }
    }
}
