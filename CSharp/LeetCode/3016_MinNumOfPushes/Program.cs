using System;

public class Solution {
    public int MinimumPushes(string word)
    {
        int answer = 0;
        int[] count = new int[26];

        foreach (char c in word)
        {
            count[c - 'a']++;
        }

        Array.Sort(count);  
        Array.Reverse(count);

        for (int i = 0; i < 26; i++)
        {
            int group = (i / 8) + 1;
            answer += count[i] * group;
        }
        
        return answer;
    }
}

class Program {
    static void Main(string[] args) {
        var sol = new Solution();
        Console.WriteLine(sol.MinimumPushes("leet"));
    }
}