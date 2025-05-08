
static void Main()
{
    int t = int.Parse(Console.ReadLine());
    for (int i = 0; i < t; i++)
    {
        GetCycleCount();
    }
}

static int GetCycleCount()
{
    int cycleCount = 0;

    int n = int.Parse(Console.ReadLine());
    var data = Console.ReadLine().Split().Select((x) => int.Parse(x)).ToArray();
    
    List<int>[] graph = new List<int>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        graph[i].Add(data[i]);
        graph[data[i]].Add(i);
    }

    int[] depth = new int[n + 1];

    for (int i = 1; i <= n; i++)
    {
        depth[i] = -1;
    }
    
    for (int i = 1; i <= n; i++)
    {
        if (depth[i] != -1) continue;

        depth[i] = 0;
        if (IsCycle(i, graph, depth))
        {
            cycleCount++;
        }
    }
    
    

    return cycleCount;
}

static bool IsCycle(int now, List<int>[] graph, int[] depth)
{
    if (depth[now] == 0)
    {
        return true;
    }

    foreach (var neighbor in graph[now])
    {
        depth[neighbor] = depth[now] + 1;
        var result = IsCycle(neighbor, graph, depth);
    }
    
}