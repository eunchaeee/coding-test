public class Solution
{
    public int[] GetStrongest(int[] arr, int k)
    {
        List<int> answer = new List<int>();

        Array.Sort(arr);
        int n = arr.Length;
        int m = arr[(n - 1) / 2];

        // indices
        int l = 0;
        int r = n - 1;

        while (k > 0)
        {
            if (Math.Abs(arr[l] - m) > Math.Abs(arr[r] - m))
            {
                answer.Add(arr[l]);
                l++;
            }
            else
            {
                answer.Add(arr[r]);
                r--;
            }

            k--;
        }
        

        return answer.ToArray();
    }

    public static void Main()
    {
        var sol = new Solution();
        var result = sol.GetStrongest([1,2,3,4,5], 2);
        var result2 = sol.GetStrongest([1, 1, 3, 5, 5], 2);
        var result3 = sol.GetStrongest([6,7,11,7,6,8], 5);
        
        Console.WriteLine(string.Join(" ", result));
        Console.WriteLine(string.Join(" ", result2));
        Console.WriteLine(string.Join(" ", result3));
    }
}