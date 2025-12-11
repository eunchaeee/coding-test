public class Solution {
    public int SingleNumber(int[] nums)
    {
        Dictionary<int, bool> dict = new Dictionary<int, bool>();

        foreach (var i in nums)
        {
            if (dict.ContainsKey(i))
            {
                dict.Remove(i);
            }
            else
            {
                dict[i] = true;
            }
        }

        return dict.Keys.First();
    }

    public int SingleNumber2(int[] nums)
    {
        int answer = 0;
        foreach (var n in nums)
        {
            answer ^= n;
        }

        return answer;
    }

    static void Main()
    {
        Solution sol = new Solution();
        int[] nums = new int[] { 4,1,2,1,2 };
        Console.WriteLine(sol.SingleNumber2(nums));
    }
}