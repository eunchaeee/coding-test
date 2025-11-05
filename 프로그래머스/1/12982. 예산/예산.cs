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

}