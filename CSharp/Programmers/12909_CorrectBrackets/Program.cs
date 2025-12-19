using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(')
                stack.Push(c);
            else
            {
                if (stack.Count == 0)
                    return false;
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }

    public bool solution2(string s)
    {
        int total = 0;

        foreach (var c in s)
        {
            if (c == '(')
                total++;
            else 
                total--;

            if (total < 0) return false;
        }

        return total == 0;
    }
}