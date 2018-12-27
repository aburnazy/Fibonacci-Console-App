using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class FibonacciGenerator
    {
        private Dictionary<int, int> _cache = new Dictionary<int, int>();

        private int Fibonacci(int number) => number < 2 ? number : FibonacciValue(number - 1) + FibonacciValue(number - 2);

        private int FibonacciValue(int number)
        {
            if (!_cache.ContainsKey(number))
            {
                _cache.Add(number, Fibonacci(number));
            }

            return _cache[number];
        }

        public IEnumerable<int> Generate(int number)
        {
            for (int i=0; i<number; i++)
            {
                yield return FibonacciValue(i);
            }
        }
    }
}
