public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i = 1; i*i <= n; i++)
        {
            if (n % i == 0)
            {
                answer += i;
                
                int apart = n / i;
                if (i != apart)
                {
                    answer += apart;
                }
            }
        }
        
        return answer;
    }
}