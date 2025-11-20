public class Solution {
    public int solution(int n) 
    {
        int answer = 0;
        bool[] filter = new bool[n + 1];

        for (int i = 0; i < n + 1; i++)
        {
            filter[i] = true;
        }

        for (int i = 2; i < n + 1; i++)
        {
            int factor = 2;
            while (factor * i < n + 1)
            {
                filter[factor * i] = false;
                factor++;
            }
        }

        for (int i = 2; i < n + 1; i++)
        {
            if (filter[i]) answer++;
        }
        
        return answer;
    }
}