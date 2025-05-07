using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int startIdx = commands[i, 0] - 1;
            int endIdx = commands[i, 1] - 1;
            int[] picked = array.Skip(startIdx).Take(endIdx - startIdx + 1).ToArray();
            Array.Sort(picked);
            answer[i] = (picked[commands[i, 2] - 1]);
        }
        return answer;
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();

        int[] array = [1, 5, 2, 6, 3, 7, 4];
        int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
         
        var result = sol.solution(array, commands);
        Console.WriteLine(string.Join(" ", result));
    }
}