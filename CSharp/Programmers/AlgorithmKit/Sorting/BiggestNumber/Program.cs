using System;

public class Solution {
    public string solution(int[] numbers)
    {
        if (numbers.All(c => c == 0)) return "0";
        
        int[] sorted = numbers.OrderByDescending((a) => a.ToString()).ToArray();

        for (int i = 1; i < sorted.Length; i++)
        {
            int target = sorted[i];
            int j = i - 1;
            
            while (j >= 0 && !Compare(sorted[j], target))
            {
                sorted[j + 1] = sorted[j];
                j--;
            }

            sorted[j + 1] = target;
            //Console.WriteLine(string.Join(" ", sorted));
        }

        return string.Join("", sorted);
    }

    public string solutionGPT(int[] numbers)
    {
        // 숫자를 문자열로 변환
        string[] strNums = numbers.Select(n => n.ToString()).ToArray();
        
        // 커스텀 정렬 : 두 수를 이어붙인 결과 중 큰 순서대로 정렬
        // b+a > a+b 이면 CompareTo 값이 양수 => b를 a 앞으로 보낸다.
        Array.Sort(strNums, (a, b) => (b + a).CompareTo(a + b));
        
        string result = string.Join("", strNums);
        if (result[0] == '0') return "0";

        return result;
    }
    
    public bool Compare(int a, int b)
    {
        int smaller = int.Parse(b.ToString() + a.ToString());
        int bigger = int.Parse(a.ToString() + b.ToString());
        Console.WriteLine($"{smaller}, {bigger}, {smaller < bigger}");
        return smaller <= bigger;
    }

    public static void Main(string[] args)
    {
        var sol = new Solution();
        //Console.WriteLine(sol.solution([6, 10, 2]));
        Console.WriteLine(sol.solutionGPT([3, 30, 34, 5, 9]));
        Console.WriteLine(sol.solutionGPT([0, 0, 0]));
    }
}