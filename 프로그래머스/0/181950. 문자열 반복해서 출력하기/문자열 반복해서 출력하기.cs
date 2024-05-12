using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);
        int cnt = 0;
        while(cnt <a)
        {
            Console.Write(s1);    
            cnt++;
        }
    }
}