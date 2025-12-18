using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int brown, int yellow)
    {
        int[] answer = new int[] { };
        
        int total = brown + yellow;

        List<int[]> divider = new List<int[]>();


        for (int i = 1; i * i <= total; i++)
        {
            if (total%i == 0)
            {
                divider.Add(new int[] { total / i, i });
            }
        }

        foreach (int[] pair in divider)
        {
            int sum = pair[0] + pair[1];
            if (sum == brown/2 + 2)
            {
                answer = pair;
            }
        }
        
        return answer;
    }
}