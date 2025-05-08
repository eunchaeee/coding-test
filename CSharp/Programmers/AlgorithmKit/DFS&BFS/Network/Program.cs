using System;

public class Solution {
    public int solution(int n, int[,] computers) {
        int answer = 0;
        bool[] visited = new bool[n];
        
        for (int i = 0; i < n; i++)
        {
            if (DFS(i, computers, visited))
            {
                answer++;
            }
        }
        return answer;
    }

    public bool DFS(int now, int[,] computers, bool[] visited)
    {
        if (visited[now]) return false;

        visited[now] = true;
        
        for (int i = 0; i < computers.GetLength(0); i++)
        {
            if (i == now) continue;

            if (computers[now, i] == 1)
            {
                DFS(i, computers, visited);
            }
        }

        return true;
    }

    public static void Main()
    {
        var sol = new Solution();
        var computers1 = new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };
        var computers2 = new int[,] { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } };
        Console.WriteLine(sol.solution(3, computers1));
        Console.WriteLine(sol.solution(3, computers2));
    }
}