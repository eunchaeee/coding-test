using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {

        int idx1 = 0;
        int idx2 = 0;
        
        for (int i = 0; i < goal.Length; i++)
        {
            if (idx1 < cards1.Length && goal[i] == cards1[idx1])
            {
                idx1++;
            }
            else if (idx2 < cards2.Length && goal[i] == cards2[idx2])
            {
                idx2++;
            }
            else
            {
                return "No";
            }
        }
        
        return "Yes";
    }

    public static void Main()
    {
        Solution sol = new Solution();

        string[] cards1 = new string[] {"i", "drink", "water" };
        string[] cards2 = new string[] { "want", "to" };
        string[] cards3 = new[] { "i", "water", "drink" };

        string[] goal = ["i", "want", "to", "drink", "water"];
        
        
        Console.WriteLine(sol.solution(cards1, cards2, goal));
        Console.WriteLine(sol.solution(cards3, cards2, goal));
    }
}

