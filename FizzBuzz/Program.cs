using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(1, 100).ToList().ForEach(i =>
            {
                var result = i.ToString();
                if (i % 3 == 0) result = "Fizz";
                if (i % 5 == 0)
                {
                    if (result == "Fizz") result += " Buzz";
                    else result = "Buzz";
                }
                Console.WriteLine(i.ToString() + " -> " + result);
            });

            Console.Read();
        }
    }
}
