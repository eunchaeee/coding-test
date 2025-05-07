using System;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        int n = progresses.Length;
        int[] days = new int[n];
        for (int i = 0; i < n; i++)
        {
            days[i] = ((100 - progresses[i]) + (speeds[i] - 1)) / speeds[i];
        }

        int prev = 0;
        while (prev < n)
        {
            int follow = prev + 1;
            while (follow < n && days[follow] <= days[prev])
            {
                follow++;
            }
            answer.Add(follow - prev);
            prev = follow;
        }
        
        return answer.ToArray();
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        int[] progress1 = [93, 30, 55];
        int[] speeds1 = [1, 30, 5];
        int[] progress2 = [95, 90, 99, 99, 80, 99];
        int[] speeds2 = [1, 1, 1, 1, 1, 1];

        sol.solution(progress1, speeds1);
        sol.solution(progress2, speeds2);
    }
}