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
using BFS_Shortest_Reach;

class Result
{

    /*
     * Complete the 'bfs' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     *  3. 2D_INTEGER_ARRAY edges
     *  4. INTEGER s
     */

    public static List<int> bfs(int n, int m, List<List<int>> edges, int s)
    {
        // n : 노드 수, m : 간선 수, edges, s : 시작위치
        
        // 인접 리스트 그래프 초기화
        List<int>[] graph = new List<int>[n + 1];

        for (int i = 1; i < n + 1; i++)
        {
            graph[i] = new List<int>();
        }
        
        // 간선 입력
        for (int i = 0; i < edges.Count; i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];
            graph[u].Add(v);
            graph[v].Add(u);
        }
        
        // 거리 배열 초기화
        int[] dist = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            dist[i] = -1;
        }
        
        // 큐 초기화
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(s);
        dist[s] = 0;
        
        while (queue.Count > 0)
        {
            int current = queue.Dequeue();
            foreach (var neighbor in graph[current])
            {
                if (dist[neighbor] == -1)
                {
                    dist[neighbor] = dist[current] + 6;
                    queue.Enqueue(neighbor);
                }
            }
        }

        List<int> answer = new();
        for (int i = 1; i < dist.Length; i++)
        {
            if (i != s)
            {
                answer.Add(dist[i]);
            }
        }
        
        return answer;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Result.bfs(4, 2, new List<List<int>>(){new List<int>() {1, 2}, new List<int>() {1, 3}}, 1));
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        //
        // int q = Convert.ToInt32(Console.ReadLine().Trim());
        //
        // for (int qItr = 0; qItr < q; qItr++)
        // {
        //     string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        //
        //     int n = Convert.ToInt32(firstMultipleInput[0]);
        //
        //     int m = Convert.ToInt32(firstMultipleInput[1]);
        //
        //     List<List<int>> edges = new List<List<int>>();
        //
        //     for (int i = 0; i < m; i++)
        //     {
        //         edges.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(edgesTemp => Convert.ToInt32(edgesTemp)).ToList());
        //     }
        //
        //     int s = Convert.ToInt32(Console.ReadLine().Trim());
        //
        //     List<int> result = Result.bfs(n, m, edges, s);
        //
        //     textWriter.WriteLine(String.Join(" ", result));
        // }
        //
        // textWriter.Flush();
        // textWriter.Close();
    }
}