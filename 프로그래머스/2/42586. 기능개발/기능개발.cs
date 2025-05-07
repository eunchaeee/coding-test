using System;
using System.Collections.Generic;

public class Solution 
{

    public int[] solution(int[] progresses, int[] speeds) 
    {
        List<int> answer = new List<int>();
        int n = progresses.Length;
        int[] days = new int[n];
        for (int i = 0; i < n; i++)
        {
            days[i] = ((100 - progresses[i]) + (speeds[i] - 1)) / speeds[i];
        }

        int prev = 0;
        while (prev < n)
        {
            int follow = prev + 1;
            while (follow < n && days[follow] <= days[prev])
            {
                follow++;
            }
            answer.Add(follow - prev);
            prev = follow;
        }
        
        return answer.ToArray();
    }
}