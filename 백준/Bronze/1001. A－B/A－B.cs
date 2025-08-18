using System;

namespace Baekjoon1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            Console.WriteLine(A - B);
        }
    }
}
