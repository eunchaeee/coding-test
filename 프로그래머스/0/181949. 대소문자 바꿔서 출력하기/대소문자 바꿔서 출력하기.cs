using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        String result = "";
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                result += c.ToString().ToUpper();
            }
            else
            {
                result += c.ToString().ToLower();
            }
        }
        Console.WriteLine(result);
    }
}