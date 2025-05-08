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
}