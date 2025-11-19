public class Solution {
    public string solution(string s) {
        string answer = "";
        int l = s.Length;
        
        if (l % 2 == 1)
        {
            answer = s[l / 2].ToString();
        }
        else
        {
            answer = s[l / 2 - 1].ToString() + s[l / 2].ToString();
        }
        return answer;
    }
}