using System;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d);

        for (int i = 0; i < d.Length; i++)
        {
            budget -= d[i];
            if (budget < 0)
            {
                return i;
            }
        }
        return d.Length;
    }
}