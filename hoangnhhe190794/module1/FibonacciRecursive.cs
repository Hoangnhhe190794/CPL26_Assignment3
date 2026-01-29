using System;

namespace HoangNHH.Module1
{
    public class FibonacciRecursive : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (!flag)
                throw new ArgumentException("flag must be true for recursive implementation");

            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (n <= 1) return n;

            return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
        }
    }
}
