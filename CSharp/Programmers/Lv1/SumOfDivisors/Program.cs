public class Solution {
    
    // 단점:
    // 소수일 경우 처음부터 끝까지 다 돌아야함. (시간복잡도 O(n))
    // filter라는 추가적인 메모리까지 사용해야함.
    public static int solution(int n) {
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

    // 시간복잡도 O(루트N)
    public static int solution2(int n)
    {
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
    
    static void Main()
    {
        Console.WriteLine(solution(4));
    }
}