using System.Text;

public class Solution {
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string x in s.Split())
        {
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
}