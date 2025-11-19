public class Solution {
    public bool solution(string s)
    {
        bool answer = true;
        if (s.Length == 4 || s.Length == 6)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                {
                    answer = false;
                }
            }
        }
        else
        {
            answer = false;
        }
        
        
        return answer;
    }
}