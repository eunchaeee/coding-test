using System;

public class Solution {
    public long solution(long n) {
        double sqrt = Math.Sqrt(n);
        if (sqrt % 1 == 0)
        {
            return (long)Math.Pow(sqrt + 1, 2);
        }
        return -1;
    }
}