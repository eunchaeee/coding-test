using System;
using System.Linq;

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

    public int solution2(int n, int[,] costs)
    {

        int[,] costMap = new int[n, n];
        List<int>[] map = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            map[i] = new List<int>();
        }
        
        for (int i = 0; i < costs.GetLength(0); i++)
        {
            costMap[costs[i, 0], costs[i, 1]] = costs[i, 2];
            costMap[costs[i, 1], costs[i, 0]] = costs[i, 2];
            map[costs[i, 0]].Add(costs[i, 1]);
            map[costs[i, 1]].Add(costs[i, 0]);
        }

        int answer = 0;
        for (int i = 0; i < n; i++)
        {
            var answers = new List<int> { };
            DFS(i, n, new List<int> { i }, answers, costMap, map);
            int max = answers.Max();
            if (max > answer)
                answer = max;
        }
        
        return answer;
    }

    public int DFS(int start, int n, List<int> path, List<int> answers, int[,] costMap, List<int>[] map)
    {
        int cost = 0;
        
        if (path.Count == n)
        {
            answers.Add(cost);
            return cost;
        }
        
        foreach (int next in map[start])
        {
            if (path.Contains(next)) continue;

            cost += costMap[start, next];
            path.Add(next);
            cost = Math.Max(cost, DFS(next, n, path, answers, costMap, map));
            path.RemoveAt(path.Count - 1);
            cost -= costMap[start, next];
        }

        return cost;
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(4, new int[,]
        {
            {0, 1, 1}, {0, 2, 2}, {1, 2, 5}, {1, 3, 1}, {2, 3, 8}
        }));
    }
}