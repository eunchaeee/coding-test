
using System.Text;

public class Solution 
{
    public string ReverseParentheses(string s)
    {
        int n = s.Length;
        int[] pair = new int[n];
        var st = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            if (s[i] == '(') st.Push(i);
            else if (s[i] == ')')
            {
                int j = st.Pop();
                pair[i] = j;
                pair[j] = i;
            }
        }

        var sb = new StringBuilder(n);
        for (int i = 0, dir = 1; i < n; i += dir)
        {
            char c = s[i];
            if (c == '(' || c == ')')
            {
                i = pair[i];
                dir = -dir;
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    public static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.ReverseParentheses("ta()usw((((a))))"));
    }
}