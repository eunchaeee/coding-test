using System;
using System.Text;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        
        // Initialize graph
        List<int>[] graph = new List<int>[n + 1];
        for (int i = 1; i < n + 1; i++)
        {
            graph[i] = new List<int>();
        }
        
        // Set edges
        for (int i = 0; i < m; i++)
        {
            var edge = Console.ReadLine().Split();
            int u = int.Parse(edge[0]);
            int v = int.Parse(edge[1]);
            graph[u].Add(v);
            graph[v].Add(u);
        }        
        
        // visited
        bool[] visited = new bool[n + 1];
        
        // BFS

        int count = 0;
        
        for (int i = 1; i < n + 1; i++)
        {        
            Queue<int> queue = new Queue<int>();

            if (!visited[i])
            {
                queue.Enqueue(i);
                visited[i] = true;

                while (queue.Count > 0)
                {
                    int now = queue.Dequeue();

                    foreach (int neighbor in graph[now])
                    {
                        if (!visited[neighbor])
                        {
                            queue.Enqueue(neighbor);
                            visited[neighbor] = true;
                        }
                    }
                }

                count++;
            }
        }
        
        Console.Write(count);
    }
}