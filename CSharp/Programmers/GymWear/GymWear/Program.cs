using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve)
    {
        int[] map = new int[n + 1];

        for (int i = 1; i <= n; i++)
            map[i] = 1;

        foreach (int i in lost)
            map[i]--;

        foreach (var i in reserve)
            map[i]++;
        
        for (int i = 1; i < n; i++)
        {
            if (map[i] == 0)
            {
                if (i + 1 <= n && map[i + 1] == 2)
                {
                    map[i] = 1;
                    map[i + 1] = 1;
                }
            }
            else if (map[i] == 2)
            {
                if (i + 1 <= n && map[i + 1] == 0)
                {
                    map[i] = 1;
                    map[i + 1] = 1;
                }
            }
        }

        int answer = 0;

        for (int i = 1; i <= n; i++)
        {
            if (map[i] == 1 || map[i] == 2)
                answer++;
        }
        
        return answer;
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(5, new int[]{2, 4}, new int[] {1, 3, 5}));
        Console.WriteLine(sol.solution(5, new int[]{2, 4}, new int[] {3}));
        Console.WriteLine(sol.solution(3, new int[]{3}, new int[] {1}));
    }
}