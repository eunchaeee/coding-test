using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int cutTheTreeReview(List<int> data, List<List<int>> edges)
    {
        int n = data.Count;
        int[] treeValues = new int[n + 1];

        List<int>[] graph = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            graph[i] = new List<int>();
        }
        
        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        bool[] visited = new bool[n + 1];
        // 아무 노드나 루트로 잡고 거기서부터 dfs
        dfs(1, graph, treeValues, visited, data);
        
        int total = data.Sum();
        int minDiff = int.MaxValue;
        
        for (int i = 1; i <= n; i++)
        {
            int diff = Math.Abs((total - treeValues[i]) - treeValues[i]);
            minDiff = Math.Min(diff, minDiff);
        }
        
        return minDiff;
    }

    public static int dfs(int node, List<int>[] graph, int[] treeValues, bool[] visited, List<int> data)
    {
        visited[node] = true;
        int treeValue = data[node - 1];

        foreach (int neighbor in graph[node])
        {
            if (!visited[neighbor])
            {
                treeValue += dfs(neighbor, graph, treeValues, visited, data);
            }
        }

        treeValues[node] = treeValue;
        return treeValue;
    }




    /*
     * Complete the 'cutTheTree' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY data
     *  2. 2D_INTEGER_ARRAY edges
     */

    /*
     * 1. data : 각 노드의 가중치
     * 2. edges : 간선 정보
     */
    
    public static int cutTheTreeFirst(List<int> data, List<List<int>> edges)
    {
        // data : 0-indexed
        // others : 1-indexed
        int nodes = data.Count;
        int total = data.Sum();
        
        // Intialize graph
        List<int>[] graph = new List<int>[nodes + 1];

        for (int i = 1; i < nodes + 1; i++)
        {
            graph[i] = new List<int>();
        }

        // write the edge datas & outdegrees
        int[] outdegrees = new int[nodes + 1];
        
        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
            outdegrees[edge[0]]++;
            outdegrees[edge[1]]++;
        }
        //Console.WriteLine(string.Join(" ", outdegrees));

        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[nodes + 1];
        for (int i = 1; i < nodes + 1; i++)
        {
            if (outdegrees[i] == 1)
            {
                queue.Enqueue(i);
            }
        }

        int[] treeValues = new int[nodes + 1];
        for (int i = 0; i < nodes; i++)
        {
            treeValues[i + 1] = data[i];
        }
        
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            visited[current] = true;

            foreach (int root in graph[current])
            {
                if (visited[root])
                    continue;
                outdegrees[root] -= 1;
                treeValues[root] += treeValues[current];
                if (outdegrees[root] == 1)
                {
                    queue.Enqueue(root);
                }
            }
        }

        float diff = float.MaxValue;
        int cutNode = -1;
        for (int i = 2; i < nodes + 1; i++)  // 
        {
            //Console.WriteLine($"data {i+1} : {string.Join(" ", data[i])}");
            float curDiff = Math.Abs(total/2.0f - treeValues[i]);
            if (curDiff < diff)
            {
                diff = curDiff;
                cutNode = i;
            }
        }
        
        // Console.WriteLine(total);
        // Console.WriteLine($"{cutNode + 1} {data[cutNode]}");
        return Math.Abs(total - 2 * treeValues[cutNode]);
    }

    public static int cutTheTreeDFS(List<int> data, List<List<int>> edges)
    {
        int n = data.Count;
        int total = data.Sum();
        int minDiff = int.MaxValue;

        List<int>[] graph = new List<int>[n + 1];
        for (int i = 1; i < n + 1; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        bool[] visited = new bool[n + 1];
        int[] subtree = new int[n + 1];

        Dfs(1);
        return minDiff;
    }

    private static int Dfs(int node)
    {
        return 0;
    }
}

// 코테에서 전역변수 많이안쓰지??
// 트리는 DFS 로??
class Solution
{
    public static void Main(string[] args)
    {
        // ex1
        // List<int> data = [100, 200, 100, 500, 100, 600];
        // List<List<int>> edges = [[1, 2], [2, 3], [2, 5], [4, 5], [5, 6]];
        // ex2
        List<int> data = [1, 2, 3, 4, 5, 6];
        List<List<int>> edges = [[1, 2], [1, 3], [2, 6], [3, 4], [3, 5]];
        // ex3
        //List<int> data = [205, 573, 985, 242, 830, 514, 592, 263, 142, 915];
        //List<List<int>> edges = [[2, 8], [10, 5], [1, 7], [6, 9], [4, 3], [8, 10], [5, 1], [7, 6], [9, 4]];
        int result = Result.cutTheTreeReview(data, edges);
        Console.WriteLine(result);
    }
}