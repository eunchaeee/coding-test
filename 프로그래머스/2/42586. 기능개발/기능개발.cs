using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds)
    {
        int n = progresses.Length;
        List<int> result = new List<int>();

        int[] days = new int[n];
        for (int i = 0; i < n; i++)
        {
            int remain = 100 - progresses[i];
            days[i] = (remain + speeds[i] - 1) / speeds[i];
        }

        List<int> answer = new List<int>();
        int count = 1;
        int current = days[0];
        
        for (int i = 1; i < n; i++)
        {
            if (days[i] <= current)
            {
                count++;
            }
            else
            {
                answer.Add(count);
                current = days[i];
                count = 1;
            }
        }
        
        answer.Add(count);

        return answer.ToArray();
    }
}