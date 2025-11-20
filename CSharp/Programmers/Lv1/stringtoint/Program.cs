public class Solution {
    public static int solution(string s) 
    {
        int answer = 0;
        int.TryParse(s, out answer);
        return answer;
    }

    static void Main()
    {
        Console.WriteLine(solution("1234"));
        Console.WriteLine(solution("-1234"));
    }
}