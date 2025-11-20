public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool[] filter = new bool[n+1];

        if (n <= 1) return n;
        
        for (int i = 1; i <= n; i++)
        {
            if (filter[i]) break;

            int apart = n / i;
            if (n % i == 0)
            {
                filter[i] = true;
                answer += i;
                
                if (i != apart)
                {
                    filter[apart] = true;
                    answer += apart;
                }
            }
        }
        
        return answer;
    }
}