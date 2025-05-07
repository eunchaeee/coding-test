using System;
using System.Linq;

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

    public bool Compare(int a, int b)
    {
        int smaller = int.Parse(b.ToString() + a.ToString());
        int bigger = int.Parse(a.ToString() + b.ToString());
        return smaller <= bigger;
    }
}