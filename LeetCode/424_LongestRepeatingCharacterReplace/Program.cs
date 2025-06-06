public class Solution 
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        char start = 'A';
        for (int i = 0; i < 26; i++)
        {
            dict[(char)(start + i)] = 0;
        }

        int n = s.Length;
        
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || s[i - 1] != s[i])
            {
                // counting start
                int value = CountRepeat(s, k, i);
                dict[s[i]] = Math.Max(dict[s[i]], value);
            }
        }
        
        return dict.OrderByDescending(pair => pair.Value).First().Value;
    }

    public int CountRepeat(string s, int k, int start)
    {
        int count = 0;
        char letter = s[start];
        int current = start;

        // forward
        while (true)
        {
            if (current >= s.Length) break;
            if (k == 0 && s[current] != letter) break;
            
            if (s[current] != letter) k--;
            
            count++;
            current++;
        }

        // reverse
        current = start - 1;
        while (true)
        {
            if (current < 0) break;
            if (k == 0 && s[current] != letter) break;

            if (s[current] != letter) k--;

            count++;
            current--;
        }
        return count;
    }

    public static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.CharacterReplacement("AABBBBBBAAAABAA", 3));
        Console.WriteLine(sol.CharacterReplacement("ABAB", 2));
        Console.WriteLine(sol.CharacterReplacement("AABABBA", 1));
        Console.WriteLine(sol.CharacterReplacement("AAAA", 1));
    }
}