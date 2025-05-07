using System;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        int width = 0;
        int height = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int max_len = Math.Max(sizes[i, 0], sizes[i, 1]);
            int min_len = Math.Min(sizes[i, 0], sizes[i, 1]);

            width = Math.Max(width, max_len);
            height = Math.Max(height, min_len);
        }
        
        return width * height;
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        var sizes = new int[,] { { 60, 50 } ,{30, 70}, {60, 30},{80,40}};
        Console.WriteLine(sol.solution(sizes));
    }
}