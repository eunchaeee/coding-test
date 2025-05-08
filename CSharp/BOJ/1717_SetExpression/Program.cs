using System;
using System.Text;

class Program
{
    private static int[] parent;

    static void Main()
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        parent = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            parent[i] = i;
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < m; i++)
        {
            var cmd = Console.ReadLine().Split();
            int op = int.Parse(cmd[0]);
            int a = int.Parse(cmd[1]);
            int b = int.Parse(cmd[2]);

            if (op == 0)
            {
                Union(a, b);
            }
            else
            {
                if (Find(a) == Find(b))
                {
                    sb.AppendLine("YES");
                }
                else
                {
                    sb.AppendLine("NO");
                }
            }
        }
        Console.Write(sb.ToString());
    }

    static int Find(int x)
    {
        if (parent[x] != x)
            parent[x] = Find(parent[x]);
        return parent[x];
    }
    
    static void Union(int a, int b)
    {
        int rootA = Find(a);
        int rootB = Find(b);

        if (rootA != rootB)
        {
            if (rootA < rootB)
            {
                parent[rootB] = rootA;
            }
            else
            {
                parent[rootA] = rootB;
            }
        }
    }
}