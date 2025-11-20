public class Solution {
    public static string solution(int n) {
        string answer = "";
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
                answer += "수";
            else
                answer += "박";
        }
        return answer;
    }

    static void Main()
    {
        Console.WriteLine(solution(3));
        Console.WriteLine(solution(4));
    }
}