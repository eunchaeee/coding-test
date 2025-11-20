using System;

public class Solution {
    public static int solution(int n) {
        int answer = 0;
        string s = n.ToString();

        for (int i = 0; i < s.Length; i++)
        {
            int.TryParse(s.Substring(i, 1), out int x);
            answer += x;
        }
        
        return answer;
    }

    static void Main()
    {
        Console.WriteLine(solution(123));
        Console.WriteLine(solution(987));
    }
}