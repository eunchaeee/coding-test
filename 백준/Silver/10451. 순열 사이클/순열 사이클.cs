using System;

class Program
{
    static int[] arr;
    static bool[] visited;

    static void DFS(int node)
    {
        visited[node] = true;
        int next = arr[node];
        if (!visited[next])
            DFS(next);
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            arr = new int[n + 1];
            visited = new bool[n + 1];

            string[] input = Console.ReadLine().Split();
            for (int i = 1; i <= n; i++)
                arr[i] = int.Parse(input[i - 1]);

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    DFS(i);
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}