

public class Solution {
    public string FrequencySort(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        var sorted = dict.OrderByDescending(pair => pair.Value).ToList();

        string answer = "";
        foreach (var pair in sorted)
        {
            answer += string.Concat(Enumerable.Repeat(pair.Key, pair.Value));
        }

        return answer;
    }

    public static void Main()
    {
        var sol = new Solution();
        Console.WriteLine(sol.FrequencySort("tree"));
    }
}