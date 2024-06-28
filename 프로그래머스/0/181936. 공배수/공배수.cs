using System;

public class Solution {
    public int solution(int number, int n, int m) {
        return Convert.ToInt32(number%n==0 && number%m==0);
    }
}