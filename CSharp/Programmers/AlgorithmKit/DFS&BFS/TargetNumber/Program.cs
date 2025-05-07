using System;

public class Solution {
    public int solution(int[] numbers, int target) {
        return DFS(0, numbers, 0, target);
    }

    public int DFS(int now, int[] numbers, int sum, int target)
    {
        // If now is on end index
        if (now == numbers.Length)
        {
            return sum == target ? 1 : 0;
        }
        
        int plus = DFS(now + 1, numbers, sum + numbers[now], target);
        int minus = DFS(now + 1, numbers, sum - numbers[now], target);
        
        return plus + minus;
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution([1, 1, 1, 1, 1], 3));
        Console.WriteLine(sol.solution([4, 1, 2, 1], 4));
    }
}