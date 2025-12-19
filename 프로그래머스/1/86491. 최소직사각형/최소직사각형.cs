using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;

        int maxMax = 0;
        int minMax = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int min = sizes[i, 0] >= sizes[i, 1]? sizes[i, 1] : sizes[i, 0];
            int max = sizes[i, 0] >= sizes[i, 1]? sizes[i, 0] : sizes[i, 1];

            if (min > minMax) minMax = min;
            if (max > maxMax) maxMax = max;
        }
        
        return maxMax * minMax;
    }
}