public class Solution {
    public long solution(int n)
    {

        if (n == 1) return 1;
        if (n == 2) return 2;
        
        long prev2 = 1;
        long prev1 = 2;

        for (int i = 3; i <= n; i++)
        {
            long cur = prev1 + prev2;
            prev2 = prev1;
            prev1 = cur;
        }
        
        return prev1 % 1234567;
    }
}