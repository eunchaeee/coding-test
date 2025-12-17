using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {

        int[] xCount = new int[10];
        int[] yCount = new int[10];

        int longer = X.Length >= Y.Length ? X.Length : Y.Length;
        
        for (int i = 0; i < longer; i++)
        {
            if (i < X.Length)
                xCount[X[i] - '0']++;

            if (i < Y.Length)
                yCount[Y[i] -'0']++;
        }

        StringBuilder sb = new StringBuilder();
        
        for (int i = 9; i >= 0; i--)
        {
            int duplicated = Math.Min(xCount[i], yCount[i]);
            
            if (i == 0 && sb.Length == 0 && xCount[i] != 0 && yCount[i] != 0)
            {
                return "0";
            }
            
            for (int j = 0; j < duplicated; j++)
                sb.Append(i);
        }

        if (sb.Length == 0) return "-1";
        return sb.ToString();
    }
}