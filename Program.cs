using System;

namespace Тест
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            SumOutput(n);
            ComOutput(n);
        }

        static void SumOutput(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{(i + j) % n,1}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ComOutput(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"[{(i * j) % n,1}] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}