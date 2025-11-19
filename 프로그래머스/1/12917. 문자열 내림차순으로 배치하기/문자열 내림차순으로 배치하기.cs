using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
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
}