public class Solution
{
    private int minUnfairness = int.MaxValue;
    private int count = 0;
    public int DistributeCookies(int[] cookies, int k)
    {
        int[] kids = new int[k];
        BackTracking(cookies, kids, 0);
        return minUnfairness;
    }

    public void BackTracking(int[] cookies, int[] kids, int idx)
    {
        count++;
        Console.WriteLine($"\n[BackTracking{count}] Cookie #{idx}");
        if (idx == cookies.Length)
        {
            int unfairness = kids.Max();
            minUnfairness = Math.Min(unfairness, minUnfairness);
            Console.WriteLine($"!!!Unfairness Update!!! {minUnfairness}");
            return;
        }

        for (int i = 0; i < kids.Length; i++)
        {
            Console.WriteLine($"Cookie #{idx} (value = {cookies[idx]}) to kids '{i}'");
            kids[i] += cookies[idx];
            Console.WriteLine($"kids : {string.Join(" ", kids)}");

            if (kids[i] < minUnfairness)
            {
                BackTracking(cookies, kids, idx + 1);
            }

            kids[i] -= cookies[idx];
            if (kids[i] == 0) break;
            Console.WriteLine($"@@@BackTrack: kids'{i}' - Cookie #{idx} (value = {cookies[idx]}) => {string.Join(" ", kids)}");
        }
    }
    
    private static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.DistributeCookies([8, 15, 10, 20, 8], 2));
    }
}