public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        int n = graph.Length;
        int[] state = new int[n];   // 0 = unvisited, 1 = visiting, 2 = safe
        List<int> result = new List<int>();
        
        for (int i = 0; i < n; i++)
        {
            if (IsSafe(i, graph, state))
                result.Add(i);
        }

        return result;
    }
    
    /*
     * 사이클이 발견되는 경우 = 방문했던 노드에 또 방문하는 경우
     */
    private bool IsSafe(int node, int[][] graph, int[] state)
    {
        if (state[node] != 0)   // 방문중이거나 safe노드이면
            return state[node] == 2;    // safe 노드이면 true, 방문중이면 사이클 발견된거니까 false

        state[node] = 1;    // mark as visiting

        foreach (int next in graph[node])
        {
            if (!IsSafe(next, graph, state))
                return false;  // 사이클이 발견되면 false
        }


        state[node] = 2;  // all chlidren are safe
        return true;
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.EventualSafeNodes(null));
    }
}

