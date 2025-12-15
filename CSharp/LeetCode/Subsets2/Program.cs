public class Solution 
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>> ();
        List<int> path = new List<int>();
        
        Array.Sort(nums);
        BackTrack(0, nums, path, result);

        return result;
    }

    public void BackTrack(int start,  int[] nums, List<int> path, List<IList<int>> result)
    {
        result.Add(new List<int>(path));
        
        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i - 1] == nums[i]) continue;

            path.Add(nums[i]);
            BackTrack(i+1, nums, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }

    static void Main()
    {
        Solution sol = new Solution();
        sol.SubsetsWithDup(new int[] { 1, 2, 2 });
    }
}