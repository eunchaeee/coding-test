using System;


public class Solution
{
    public int solution(string numbers)
    {
        HashSet<int> answers = new HashSet<int>();
        List<int> path = new List<int>();
        bool[] used = new bool[numbers.Length];


        BackTracking(numbers, path, used, answers);

        Console.WriteLine(string.Join(" ", answers));

        // find prime number
        int maxNum = answers.Max();
        bool[] compositeNumber = new bool[maxNum + 1];
        compositeNumber[0] = compositeNumber[1] = true;
        for (int i = 2; i * i <= maxNum; i++)
        {
            if (compositeNumber[i]) continue;

            for (int j = i * i; j <= maxNum; j += i)
                compositeNumber[j] = true;
        }

        // count answer
        int answer = 0;
        foreach (int n in answers) 
        {
            if (!compositeNumber[n])
            {
                answer++; 
                Console.WriteLine(n);
            }

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
            answers.Add(int.Parse(string.Join("", path)));
            BackTracking(numbers, path, used, answers);
            path.RemoveAt(path.Count - 1);
            used[i] = false;
        }
    }

    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.solution("011"));
    }
}