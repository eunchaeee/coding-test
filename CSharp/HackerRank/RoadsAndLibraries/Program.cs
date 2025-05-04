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

    /*
     * Complete the 'roadsAndLibraries' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER c_lib
     *  3. INTEGER c_road
     *  4. 2D_INTEGER_ARRAY cities
     */

    public static long roadsAndLibraries(int n, int c_lib, int c_road, List<List<int>> cities)
    {
        long answer;
        if (c_lib <= c_road)
        {
            answer = (long)c_lib * n;
            return answer;
        }
        
        // 그래프 채우기
        List<int>[] graph = new List<int>[n + 1];

        // 그래프 초기화
        for (int i = 1; i < n + 1; i++)
        {
            graph[i] = new List<int>();
        }
        
        // 간선 정보 입력
        for (int i = 0; i < cities.Count; i++)
        {
            int u = cities[i][0];
            int v = cities[i][1];
            graph[u].Add(v);
            graph[v].Add(u);
        }
        
        // 방문 여부 데이터
        bool[] visited = new bool[n + 1];

        Queue<int> queue = new Queue<int>();

        int group = 0;
        for (int i = 1; i < n + 1; i++)
        {
            if (!visited[i])
            {
                group++;
                queue.Enqueue(i);
                visited[i] = true;
                
                while (queue.Count > 0)
                {
                    var current = queue.Dequeue();
                    foreach (int neighbor in graph[current])
                    {
                        if (!visited[neighbor])
                        {
                            queue.Enqueue(neighbor);
                            visited[neighbor] = true;
                        }
                    }
                }
            }
        }
        
        answer = (long)(n - group) * c_road + (long)n * c_lib;
        return answer;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int c_lib = Convert.ToInt32(firstMultipleInput[2]);

            int c_road = Convert.ToInt32(firstMultipleInput[3]);

            List<List<int>> cities = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                cities.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(citiesTemp => Convert.ToInt32(citiesTemp)).ToList());
            }

            long result = Result.roadsAndLibraries(n, c_lib, c_road, cities);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}