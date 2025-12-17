using System.Text;


public class Solution {
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();

        int idx = 0;
        foreach (char c in s)
        {
            if (c == ' ')
            {
                sb.Append(' ');
                idx = 0;
                continue;
            }

            if (idx == 0 && char.IsLetter(c))
            {
                sb.Append(char.ToUpper(c));
            }
            else
            {
                sb.Append(char.ToLower(c));
            }

            idx++;
        }
        
        return sb.ToString();
    }
}