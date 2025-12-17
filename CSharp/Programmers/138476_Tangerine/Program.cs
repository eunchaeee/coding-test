using System;

public class Solution {
    public int solution(int k, int[] tangerine)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < tangerine.Length; i++)
        {
            dict[tangerine[i]] = dict.GetValueOrDefault(tangerine[i], 0) + 1;
        }

        List<int> nums = new List<int>();
        nums = dict.Values.ToList();
        nums.Sort();

        int off = tangerine.Length - k;

        int idx = 0;
        for (int i = 0; i < off; i++)
        {
            if (nums[idx] > 0)
            {
                nums[idx]--;
            }
            else
            {
                idx += 1;
                nums[idx]--;
            }
        }

        return nums.Count(x => x > 0);
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(6, new int[] {1, 3, 2, 5, 4, 5, 2, 3}));
    }
}