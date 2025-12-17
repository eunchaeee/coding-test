using System;
using System.Text;

public class Solution {

    public int solution2(string s)
    {
        string[] words =
        {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };

        for (int i = 0; i < words.Length; i++)
        {
            s = s.Replace(words[i], i.ToString());
        }
        
        return int.Parse(s);
    }
    
    public int solution(string s) {
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "zero", 0 }, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
            {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
        };

        StringBuilder sb = new StringBuilder();
        string chunk = "";
        

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                sb.Append(c);
            }
            else
            {
                chunk += c;
                if (dict.ContainsKey(chunk))
                {
                    sb.Append(dict[chunk]);
                    chunk = "";
                }
            }
            
        }
        
        return int.Parse(sb.ToString());
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution2("one4seveneight"));
    }
}