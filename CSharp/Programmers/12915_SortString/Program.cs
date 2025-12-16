using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strings, int n) {
        List<string> answer = new ();
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

    public string[] solution2(string[] strings, int n)
    {
        Array.Sort(strings, (a, b) =>
        {
            int c = a[n].CompareTo(b[n]);
            if (c != 0) return c;
            return a.CompareTo(b);
        });
        return strings;
    }

    static void Main()
    {
        Solution sol = new Solution();
        sol.solution(new string[] { "sun", "bed", "car" }, 1);
    }
}