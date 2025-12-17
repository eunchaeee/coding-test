using System.Text;

public class Solution 
{
    public string solution2(string s)
    {
        StringBuilder sb = new StringBuilder();

        int i = 0;
        foreach (char x in s)
        {
            if (x == ' ')
            {
                sb.Append(' ');
                i = 0;
                continue;
            }
            
            char c = i % 2 == 1 ? char.ToLower(x) : char.ToUpper(x);
            sb.Append(c);
            i++;
        }

        return sb.ToString();
    }    
    
    
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string x in s.Split())
        {
            Console.WriteLine(x);
            for (int i = 0; i < x.Length; i++)
            {

                string c = i % 2 == 1 ? x[i].ToString().ToLower() : x[i].ToString().ToUpper();
                sb.Append(c);
            }

            sb.Append(" ");
        }

        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.solution2("try hello world"));
    }
}