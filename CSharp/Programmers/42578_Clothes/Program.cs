using System;

public class Solution {
    public int solution(string[,] clothes)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            dict[type] = dict.GetValueOrDefault(type, 0) + 1;
        }

        int answer = 1;
        foreach (var pair in dict)
        {
            answer *= (pair.Value + 1);
        }
        
        return answer - 1;
    }

    static void Main()
    {
        Solution sol = new Solution();

        string[,] clothes = new string[,]
        {
            {"yellow_hat", "headgear"},
            {"blue_sunglasses", "eyewear"},
            {"green_turben", "headgear"}
        };
        
        Console.WriteLine(sol.solution(clothes));
    }
}