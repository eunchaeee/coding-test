class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int answer = n;
        
        // 단어 하나씩 검사
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            bool[] visited = new bool[26];

            // 한글자씩 검사
            for (int j = 0; j < s.Length; j++)
            {
                if (visited[s[j] - 'a'] && s[j] != s[j - 1])
                {
                    answer--;
                    break;
                }

                visited[s[j]-'a'] = true;
            }
        }
        
        Console.WriteLine(answer);
    }
}