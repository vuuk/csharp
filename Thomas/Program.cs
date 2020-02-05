using System;

namespace Thomas
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStatic ts = new ThreadStatic();
            ts.TestMethod();
        }
    }
}