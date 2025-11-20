using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        int[] arr = n.ToString().Select(c => c - '0').ToArray();
        Array.Sort(arr);
        string ordered = "";
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            ordered += arr[i];
        }
        
        long answer = 0;
        long.TryParse(ordered, out answer);
        
        return answer;
    }
}