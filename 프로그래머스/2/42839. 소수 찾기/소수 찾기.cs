using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string numbers)
    {
        HashSet<int> answers = new HashSet<int>();
        List<int> path = new List<int>();
        bool[] used = new bool[numbers.Length];


        BackTracking(numbers, path, used, answers);

        //Console.WriteLine(string.Join(" ", answers));

        // find prime number
        int maxNum = answers.Max();
        bool[] compositeNumber = new bool[maxNum + 1];
        compositeNumber[0] = compositeNumber[1] = true;
        for (int i = 2; i <= maxNum; i++)
        {
            int target = i;
            int j = i + target;
            while (j <= maxNum)
            {
                if (!compositeNumber[j])
                {
                    compositeNumber[j] = true;
                }
                j += target;
            }
        }

        // count answer
        int answer = 0;
        foreach (int n in answers) 
        {
            if (!compositeNumber[n]) answer++;
        }

        return answer;
    }

    public void BackTracking(string numbers, List<int> path, bool[] used, HashSet<int> answers)
    {

        for (int i = 0; i < numbers.Length; i++)
        {
            if (used[i]) continue;

            path.Add(numbers[i] - '0');
            used[i] = true;
            answers.Add(int.Parse(string.Join("", path.ToArray())));
            BackTracking(numbers, path, used, answers);
            path.RemoveAt(path.Count - 1);
            used[i] = false;
        }
    }
}