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
            Console.WriteLine($"{encode}, {answer}");
        }
        return answer;
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution("AB", 1));
        Console.WriteLine(sol.solution("z", 1));
        Console.WriteLine(sol.solution("a B z", 4));
    }
}