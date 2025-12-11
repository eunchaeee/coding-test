public class Solution {
    public int HammingWeight(int n)
    {
        int answer = 0;
        for (int i = 0; i < 32; i++)
        {
            if (((n >> i) & 1) == 1)
                answer++;
        }

        return answer;
    }

    public int HammingWeight2(int n)
    {
        int count = 0;
        while (n != 0)
        {
            n &= (n - 1);
            count++;
        }

        return count;
    }

    public static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.HammingWeight(2147483645));
    }
}