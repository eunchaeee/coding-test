using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int solution(string s) {
        int answer = 0;
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
}