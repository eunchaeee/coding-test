using System.Text;

public class Solution {
    public bool IsPalindrome(string s)
    {
        string s2 = "";
        StringBuilder sb = new StringBuilder();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                sb.Append(char.ToLower(s[i]));
            }
        }

        int l = sb.Length;
        for (int i = 0; i < l / 2; i++)
        {
            if (sb[i] != sb[l - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Solution sol = new Solution();
        Console.WriteLine(sol.IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(sol.IsPalindrome("race a car"));
        Console.WriteLine(sol.IsPalindrome(" "));
    }
}