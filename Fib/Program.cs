using System;

namespace Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibber = new Fibber(100);
            fibber.Fib(1, 2);
            Console.Read();
        }
    }
}
