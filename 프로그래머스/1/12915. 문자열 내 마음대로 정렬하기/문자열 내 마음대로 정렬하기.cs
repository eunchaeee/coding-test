using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] strings, int n) 
    {
        List<string> answer = new List<string>();
        List<string>[] sort = new List<string>[26];

        for (int i = 0; i < 26; i++)
        {
            sort[i] = new List<string>();
        }
        
        foreach (var s in strings)
        {
            sort[s[n] -'a'].Add(s);
        }

        for (int i = 0; i < 26; i++)
        {
            sort[i].Sort();
            answer.AddRange(sort[i]);
        }
        
        
        return answer.ToArray();
    }
}