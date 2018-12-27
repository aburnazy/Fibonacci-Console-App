using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class FibonacciGenerator
    {
        private Dictionary<Int64, Int64> _cache = new Dictionary<Int64, Int64>();

        private Int64 Fibonacci(int number) => number < 2 ? number : FibonacciValue(number - 1) + FibonacciValue(number - 2);

        private Int64 FibonacciValue(int number)
        {
            if (!_cache.ContainsKey(number))
            {
                _cache.Add(number, Fibonacci(number));
            }

            return _cache[number];
        }

        public IEnumerable<Int64> Generate(int number)
        {
            for (int i=0; i<number; i++)
            {
                yield return FibonacciValue(i);
            }
        }
    }
}
