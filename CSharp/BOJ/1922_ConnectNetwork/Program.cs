class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[][] costs = new int[m][];

        for (int i = 0; i < m; i++)
        {
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            costs[i] = input;
        }

        int[] parents = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            parents[i] = i;
        }

        Array.Sort(costs, (a, b) => a[2].CompareTo(b[2]));

        int total = 0;
        int picked = 0;
        
        for (int i = 0; i < m; i++)
        {
            int a = costs[i][0];
            int b = costs[i][1];
            int c = costs[i][2];

            while (parents[a] != a)
                a = parents[a];

            while (parents[b] != b)
                b = parents[b];

            if (a == b) continue;

            if (a < b)
                parents[b] = a;
            else
                parents[a] = b;

            total += c;
            picked++;
            if (picked == n - 1) break;
        }
        
        Console.WriteLine(total);
    }
}