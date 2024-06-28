using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        if (ineq==">" && eq=="=")
        {
            return Convert.ToInt32(n >= m);    
        }
        else if (ineq==">" && eq=="!")
        {
            return Convert.ToInt32(n > m);
        }
        else if (ineq=="<" && eq=="=")
        {
            return Convert.ToInt32(n<=m);
        }
        else
        {
            return Convert.ToInt32(n<m);    
        }
    }
}