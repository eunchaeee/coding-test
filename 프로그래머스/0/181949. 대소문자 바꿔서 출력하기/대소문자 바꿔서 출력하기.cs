using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        char[] sChar = s.ToCharArray();

        String result = "";
        foreach (char c in sChar)
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