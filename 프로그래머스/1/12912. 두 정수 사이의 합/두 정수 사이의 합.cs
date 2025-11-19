public class Solution {
    public long solution(int a, int b) 
    {
        long answer = 0;

        if (a < b)
        {
            answer = AddRange(a, b);
        }
        else if (a > b)
        {
            answer = AddRange(b, a);
        }
        else
        {
            answer = a;
        }
        
        return answer;
    }

    public long AddRange(int first, int second)
    {
        long answer = 0;
        for (int i = first; i < second + 1; i++)
        {
            answer += i;
        }

        return answer;
    }
}