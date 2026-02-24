using System;
using System.Diagnostics;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 10;
            long result = GetFibonacci(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {result}");
        }

        public static long GetFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            long previous = 0;
            long current = 1;

            for (int i = 2; i <= n; i++)
            {
                long next = previous + current;
                previous = current;
                current = next;
            }
            return current;
        }
    }
}

