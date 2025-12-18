using System;

public class Solution {
    public int solution(int n, int[,] wires) {

        // init map
        List<int>[] map = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            map[i] = new List<int>();
        }

        // map setting
        for (int i = 0; i < wires.GetLength(0); i++)
        {
            map[wires[i, 0]].Add(wires[i, 1]);
            map[wires[i, 1]].Add(wires[i, 0]);
        }
        
        int answer = n;
        
        // search
        for (int i = 0; i < wires.GetLength(0); i++)
        {
            int u = wires[i, 0];
            int v = wires[i, 1];
            
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[n + 1];
            
            queue.Enqueue(u);
            visited[u] = true;
            int uSideCount = 1;

            while (queue.Count > 0)
            {
                int now = queue.Dequeue();
                
                foreach (int next in map[now])
                {
                    if (next == v) continue;
                    if (visited[next]) continue;

                    queue.Enqueue(next);
                    visited[next] = true;
                    uSideCount++;
                }
            }


            int vSideCount = n - uSideCount;
            int diff = Math.Abs(vSideCount - uSideCount);
            //Console.WriteLine($"{u}, {v} => diff: {diff}");

            if (answer > diff) answer = diff;
        }
        
        return answer;
    }

    static void Main()
    {
        Solution sol = new Solution();
        
        Console.WriteLine(sol.solution(4, new int[,] {{1, 2}, {2, 3}, {3, 4}}));
        
    }
}