public class Solution {
    public string solution(string s) {
        string answer = "";

        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s.Substring(i, 1) == " ")
            {
                answer += " ";
                count = 0;
                continue;
            }
            
            if (count % 2 == 0)
            {
                answer += s.Substring(i, 1).ToUpper();
            }
            else
            {
                answer += s.Substring(i, 1).ToLower();
            }

            count++;
        }
        
        return answer;
    }
}