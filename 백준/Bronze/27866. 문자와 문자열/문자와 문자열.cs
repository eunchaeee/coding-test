using System;

namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	string S = Console.ReadLine()!;
            int i = int.Parse(Console.ReadLine()!);
            Console.WriteLine(S[i-1]);
        }
    }
}