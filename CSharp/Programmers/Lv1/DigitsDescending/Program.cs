using System.Text;

public class Solution {
    public static long solution(long n) 
    {
        int[] arr = n.ToString().Select(c => c - '0').ToArray();
        Array.Sort(arr);

        var sb = new StringBuilder();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            sb.Append(arr[i]);
        }
        return long.Parse(sb.ToString());
    }

    static void Main()
    {
        Console.WriteLine(solution(118372));
    }
}