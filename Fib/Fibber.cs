using System;

namespace Fib
{
    public class Fibber
    {
        private int _max;

        public Fibber(int max)
        {
            _max = max;
        }

        public void Fib(int prev, int curr)
        {
            Console.Write($"{prev},");
            var next = prev + curr;
            if (next >= _max)
            {
                Console.WriteLine($"{curr},{next}");
                return;
            }
            Fib(curr, next);
        }
    }
}
