public class Solution 
{
    public int MinDifference(int[] nums)
    {
        int n = nums.Length;

        if (n <= 4) return 0;
        
        Array.Sort(nums);

        int apart = n - 4;
        int minDiff = int.MaxValue;
        for (int i = 0; i < n - apart; i++)
        {
            for (int j = i + apart; j < n; j++)
            {
                minDiff = Math.Min(minDiff, nums[j] - nums[i]);
            }
        }

        return minDiff;
    }

    public static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.MinDifference([1, 5, 0, 10, 14]));
    }
}