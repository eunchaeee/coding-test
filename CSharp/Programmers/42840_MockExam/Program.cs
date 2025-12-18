using System;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>{};

        int[] p1 = new int[] { 1, 2, 3, 4, 5 };
        int[] p2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] p3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] count = new int[3];
        
        for (int i = 0; i < answers.Length; i++)
        {
            if ((p1[i % p1.Length] ^ answers[i]) == 0) count[0]++;
            if ((p2[i % p2.Length] ^ answers[i]) == 0) count[1]++;
            if ((p3[i % p3.Length] ^ answers[i]) == 0) count[2]++;
        }

        int max = count.Max();
        
        for (int i = 0; i < count.Length; i ++)
        {
            if (count[i] == max) answer.Add(i+1);
        }
        return answer.ToArray();
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution(new int[] {1, 2, 3, 4, 5}));
    }
}