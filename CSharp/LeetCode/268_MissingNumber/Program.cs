public class Solution 
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int answer = 0;
        
        for (int i = 0; i < n; i++)
        {
            answer ^= (i + 1);
            answer ^= nums[i];
        }

        return answer;
    }

    static void Main()
    {
        Solution sol = new Solution();
        int[] nums = new[] { 9,6,4,2,3,5,7,0,1};
        Console.WriteLine(sol.MissingNumber(nums));
    }
}