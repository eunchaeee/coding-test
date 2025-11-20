public class Solution {
    public int[] solution(long n) {
        string s = n.ToString();
        int[] answer = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            int.TryParse(s.Substring(s.Length - 1 - i, 1), out int x);
            answer[i] = x;
        }
        
        return answer;
    }
}