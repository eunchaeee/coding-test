using System;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d);
        int count = 0;
        for (int i = 0; i < d.Length; i++)
        {
            if (budget - d[i] < 0)
            {
                break;
            }

            budget -= d[i];
            count++;
        }
        return count;
    }

    public static void Main()
    {
        Solution sol = new Solution();
        int[] d1 = new int[5] { 1, 3, 2, 5, 4 };
        int[] d2 = new int[4] { 2, 2, 3, 3 };
        sol.solution(d1, 9);
        sol.solution(d2, 10);
    }
}