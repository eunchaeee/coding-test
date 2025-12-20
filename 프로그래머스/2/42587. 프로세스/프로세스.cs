using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location)
    {
        List<int> pList = new List<int>();
        int n = priorities.Length;
        List<int[]> pq = new List<int[]>();
        bool[] finished = new bool[n];
        
        for (int i = 0; i < n; i++)
        {
            pq.Add(new int[] { i, priorities[i] });
        }
        
        pq.Sort((a, b) => b[1].CompareTo(a[1]));
        
        int count = 0;
        while (!finished[location])
        {
            for (int i = 0; i < n; i++)
            {
                if (finished[i]) continue;
                if (pq[count][1] > priorities[i])
                {
                    continue;
                }
                else
                {
                    finished[i] = true;
                    count++;
                    if (i == location) break;
                }
            }
        }
        return count;
    }

}