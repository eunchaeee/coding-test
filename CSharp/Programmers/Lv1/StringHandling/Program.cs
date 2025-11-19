public class Solution {
    public static bool solution(string s) {
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

    public static bool solution2(string s)
    {
        bool answer = false;
        if (s.Length == 4 || s.Length == 6)
            answer = int.TryParse(s, out int i);
        return answer;
    }

    public static void Main()
    {
        Console.WriteLine(solution("a234"));
        Console.WriteLine(solution("1234"));
        Console.WriteLine(solution2("a234"));
        Console.WriteLine(solution2("1234"));
    }
}