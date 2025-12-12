
public class Solution 
{
    public IList<IList<int>> SubsetByBackTracking(int[] nums)
    {
        var result = new List<IList<int>>();
        Backtrack(0, nums, new List<int>(), result);
        return result;
    }

    private void Backtrack(int start, int[] nums, List<int> path, List<IList<int>> result)
    {
        result.Add(new List<int>(path));
        for (int i = start; i < nums.Length; i++)
        {
            path.Add(nums[i]);
            Backtrack(i+1, nums, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
    
    public IList<IList<int>> Subsets2(int[] nums)
    {
        var answer = new List<IList<int>>();
        int n = nums.Length;
        int limit = 1 << n;

        for (int mask = 0; mask < limit; mask++)
        {
            var temp = new List<int>();
            for (int j = 0; j < n; j++)
            {
                if ((mask & (1 << j)) != 0)
                    temp.Add(nums[j]);
            }
            answer.Add(temp);
        }
        return answer;
    }
    
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> answer = new List<IList<int>>();

        int limit = (int)(MathF.Pow(2, nums.Length));
        for (int i = 0; i < limit; i++)
        {
            int bits = i;
            IList<int> temp = new List<int>();
            int cnt = 0;

            while (bits > 0)
            {
                if ((bits & 1) == 1)
                {
                    temp.Add(nums[cnt]);
                }

                cnt++;
                bits >>= 1;
            }
            answer.Add(temp);
        }
        return answer;
    }

    public static void Main()
    {
        Solution sol = new Solution();
        int[] nums = new int[] { 1, 2, 3 };

        var ans = sol.Subsets(nums);
    }
}