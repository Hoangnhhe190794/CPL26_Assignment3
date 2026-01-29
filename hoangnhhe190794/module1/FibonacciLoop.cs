using System;

namespace HoangNHH.Module1
{
    public class FibonacciLoop : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (flag)
                throw new ArgumentException("flag must be false for loop implementation");

            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
            if (n <= 1) return n;

            int a = 0, b = 1;

            for (int i = 2; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
