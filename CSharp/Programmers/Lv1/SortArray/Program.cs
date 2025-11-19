using System.Collections.Generic;

public class Solution
{
    public string[] solution2(string[] strings, int n)
    {
        List<string> answer = new List<string>();
        var pq = new PriorityQueue<string, (char p1, string p2)>();

        foreach (string s in strings)
        {
            pq.Enqueue(s, (s[n], s));
        }

        while (pq.Count > 0)
        {
            answer.Add(pq.Dequeue());
        }
        
        return answer.ToArray();
    }
    
    public string[] solution(string[] strings, int n)
    {
        Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();

        foreach (string s in strings)
        {
            if (dict.ContainsKey(s[n]))
            {
                dict[s[n]].Add(s);
            }
            else
            {
                dict[s[n]] = new List<string>() { s };
            }
        }

        List<string> answer = new List<string>();
        
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (dict.ContainsKey(i))
            {
                var temp = dict[i];
                temp.Sort();
                answer.AddRange(temp);
            }
        }

        return answer.ToArray();
    }

    static void Main()
    {
        
    }
}