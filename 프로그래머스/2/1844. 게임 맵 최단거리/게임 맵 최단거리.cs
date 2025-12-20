using System;
using System.Collections.Generic;

class Solution {
        public int solution(int[,] maps)
    {
        int answer = 0;
        int[] dx = new int[4] { 0, 0, 1, -1 };
        int[] dy = new int[4] { 1, -1, 0, 0 };
        
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);

        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));
        while (queue.Count > 0)
        {
            (int x, int y) = queue.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx == 0 && ny == 0)
                    continue;
                if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                    continue;
                if (maps[nx, ny] == 0 || maps[nx, ny] > 1)
                    continue;
                
                maps[nx, ny] = maps[x, y] + 1;
                queue.Enqueue((nx, ny));
            }
        }

        answer = maps[n - 1, m - 1] == 1 ? -1 : maps[n - 1, m - 1];
        
        return answer;
    }
}