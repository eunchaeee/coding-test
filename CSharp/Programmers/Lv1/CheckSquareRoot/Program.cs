public class Solution {
    public static long solution(long n) {
        double sqrt = Math.Sqrt(n);
        if (sqrt % 1 == 0)
        {
            return (long)Math.Pow(sqrt + 1, 2);
        }
        return -1;
    }

    public static void Main()
    {
        Console.WriteLine(solution(121));
        Console.WriteLine(solution(3));
    }
}