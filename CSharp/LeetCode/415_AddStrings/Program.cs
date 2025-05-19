public class Solution {
    public string AddStrings(string num1, string num2)
    {
        int maxLen = num1.Length > num2.Length ? num1.Length : num2.Length;
        int[] answer = new int[maxLen + 1];
        for (int i = 0; i < maxLen; i++)
        {
            int sum = 0;
            int idx1 = (num1.Length - 1) - i;
            int idx2 = (num2.Length - 1) - i;
            
            if (idx1 >= 0)
                sum += num1[num1.Length - i - 1] - '0';
            
            if (idx2 >= 0)
                sum += num2[num2.Length - i - 1] - '0';

            answer[i] += sum;
            if (answer[i] >= 10)
            {
                answer[i] -= 10;
                answer[i + 1] += 1;
            }
        }
        
        Array.Reverse(answer);
        string result = string.Join("", answer.Select(n => n.ToString())).TrimStart('0');

        if (result == "") result = "0";
        return result;
    }

    public static void Main()
    {
        var sol = new Solution();
        sol.AddStrings("11", "123");
    }
}