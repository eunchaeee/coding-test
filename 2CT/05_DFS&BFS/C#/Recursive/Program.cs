using System;

class Program
{
    static void Main()
    {
        SayHi(5);
    }

    static void SayHi(int count)
    {
        if (count <= 0)
            return;
        Console.WriteLine($"Hi {count}");
        SayHi(count - 1 );
        Console.WriteLine($"End {count}");
    }
}