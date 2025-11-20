public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int alphabet_count = 26;
        
        for (int i = 0; i < s.Length; i++)
        {
            int encode = s[i] + n;
            // 소문자
            if ('a' <= s[i] && s[i] <= 'z')
            {
                answer += encode > 'z' ? (char)(encode - alphabet_count) : (char)(encode);
            }
            else if ('A' <= s[i] && s[i] <= 'Z')
            {
                answer += encode > 'Z' ? (char)(encode - alphabet_count) : (char)(encode);
            }
            else
            {
                answer += " ";
            }
        }
        return answer;
    }
}