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
}