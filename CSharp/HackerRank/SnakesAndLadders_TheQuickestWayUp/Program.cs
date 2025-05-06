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
     * Complete the 'quickestWayUp' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. 2D_INTEGER_ARRAY ladders
     *  2. 2D_INTEGER_ARRAY snakes
     */
    public static int quickestWayUp(List<List<int>> ladders, List<List<int>> snakes)
    {
        int[] board = new int[101];
        for (int i = 1; i <= 100; i++)
        {
            board[i] = i;  // 기본은 자기 자신
        }
        
        // ladders data
        foreach (var ladder in ladders)
        {
            board[ladder[0]] = ladder[1];
        }
        // snakes data
        foreach (var snake in snakes)
        {
            board[snake[0]] = snake[1];
        }
        
        // BFS
        Queue<(int pos, int move)> queue = new Queue<(int, int)>();
        bool[] visited = new bool[101];
        queue.Enqueue((1, 0));
        visited[1] = true;

        while (queue.Count > 0)
        {
            var (current, moves) = queue.Dequeue();

            if (current == 100)
            {
                return moves;
            }

            for (int dice = 1; dice <= 6; dice++)
            {
                int next = current + dice;
                if (next <= 100)
                {
                    int dest = board[next];
                    if (!visited[dest])
                    {
                        visited[dest] = true;
                        queue.Enqueue((dest, moves + 1));
                    }
                }
            }
        }

        return -1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> ladders = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                ladders.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(laddersTemp => Convert.ToInt32(laddersTemp)).ToList());
            }

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> snakes = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                snakes.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(snakesTemp => Convert.ToInt32(snakesTemp)).ToList());
            }

            int result = Result.quickestWayUp(ladders, snakes);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}