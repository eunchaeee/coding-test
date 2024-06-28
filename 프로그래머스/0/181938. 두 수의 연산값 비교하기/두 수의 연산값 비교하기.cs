using System;

public class Solution {
    public int solution(int a, int b) {
        return Math.Max(Int32.Parse(a.ToString() + b.ToString()), 2*a*b);
    }
}