class Program
{
    static string solution(string s)
    {
        string answer = "";
        int l = s.Length;

        if (l % 2 == 1)
        {
            answer = s.Substring(l / 2, 1);
        }
        else
        {
            answer = s.Substring(l / 2 - 1,2);
        }
        return answer;
    }
    
    static void Main()
    {
        Console.WriteLine(solution("abcde"));
        Console.WriteLine(solution("qwer"));
        
    }
}