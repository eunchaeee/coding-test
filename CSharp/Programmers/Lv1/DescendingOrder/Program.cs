using System.Collections.Generic;
using System.Linq;

class Program
{
    public static string solution(string s)
    {
        string answer = "";
        List<char> chars = new List<char>();
        foreach (char c in s)
        {
            chars.Add(c);
        }
        chars.Sort();
        var sorted = chars.OrderByDescending(x => x);
        answer = string.Join("", sorted);
        return answer;
    }
    
    static void Main()
    {
        Console.WriteLine(solution("Zbcdefg"));   
    }
}