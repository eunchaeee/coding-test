using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int sum = 0;
        int multiple = 1;
        foreach (int num in num_list) {
            multiple *= num;
            sum += num;
        }
        return Convert.ToInt32(multiple<sum*sum);
    }
}