using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[,] dungeons) {
        int answer = -1;

        List<int> path = new List<int>();
        bool[] visited = new bool[dungeons.GetLength(0)];
        answer = DFS(k, path, visited, dungeons);
        
        return answer;
    }

    public int DFS(int k, List<int> path, bool[] visited, int[,] dungeons)
    {
        int maxCount = path.Count;
        
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (visited[i]) continue;

            int need = dungeons[i, 0];
            int cost = dungeons[i, 1];
            
            if (k >= need && k - cost >= 0)
            {
                path.Add(i);
                visited[i] = true;
                k -= cost;
                
                maxCount = Math.Max(maxCount, DFS(k, path, visited, dungeons));
                
                path.RemoveAt(path.Count - 1);
                visited[i] = false;
                k += cost;
            }
        }

        return maxCount;
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(80, new int[,] { {80, 20}, {50, 40}, {30, 10}}));
    }
}