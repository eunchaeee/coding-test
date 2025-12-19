using System;

public class Solution {
    public int solution(int n, int[,] costs)
    {
        int[] parent = new int[n];
        for (int i = 0; i < n; i++) parent[i] = i;

        int m = costs.GetLength(0);
        int[][] edges = new int[m][];
        for (int i = 0; i < m; i++)
        {
            edges[i] = new int[] { costs[i, 0], costs[i, 1], costs[i, 2] };
        }
        
        Array.Sort(edges, (a, b) => a[2].CompareTo(b[2]));

        int answer = 0;
        int count = 0;

        foreach (var e in edges)
        {
            int a = e[0];
            int b = e[1];
            int cost = e[2];

            while (parent[a] != a)
                a = parent[a];

            while (parent[b] != b)
                b = parent[b];

            if (a == b)
                continue;

            if (a < b)
                parent[b] = a;
            else
                parent[a] = b;

            answer += cost;
            count++;

            if (count == n - 1)
                break;
        }

        return answer;
    }
}