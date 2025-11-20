public class Solution {
    public static int solution(int n)
    {
        bool[] filter = new bool[n + 1];    // true: 합성수, false: 소수
        filter[0] = filter[1] = true;
        
        for (int i = 2; i * i <= n; i++)
        {
            if (filter[i]) continue;
            
            for (int j = i * i; j <= n; j += i)
            {
                filter[j] = true;
            }
        }
        
        int answer = 0;
        for (int i = 2; i < n + 1; i++)
        {
            if (!filter[i]) answer++;
        }
        return answer;
    }

    static void Main()
    {
        solution(10);
        solution(5);
        solution(2);
    }
}