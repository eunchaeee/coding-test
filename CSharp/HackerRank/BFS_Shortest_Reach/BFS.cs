namespace BFS_Shortest_Reach;

public class BFS
{
    public static void BFS_Csharp()
    {
        // 노드 수와 간선 수
        int n = 4;
        int[,] edges =
        {
            { 1, 2 },
            { 1, 3 },
            { 2, 4 },
            { 3, 4 }
        };
        
        // 인접 리스트 생성
        List<int>[] graph = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }
        
        Console.WriteLine(graph);
        // 간선 정보 입력
        for (int i = 0; i < edges.GetLength(0); i++)
        {
            int u = edges[i, 0];
            int v = edges[i, 1];
            graph[u].Add(v);
            graph[v].Add(u);
        }
        
        // 방문 여부 배열
        bool[] visited = new bool[n + 1];
        
        // 큐 사용 (BFS)
        Queue<int> queue = new Queue<int>();
        int start = 1;
        visited[start] = true;
        queue.Enqueue(start);
        
        Console.WriteLine("BFS 방문 순서");

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            Console.Write(current + " ");

            foreach (var neighbor in graph[current])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }
}