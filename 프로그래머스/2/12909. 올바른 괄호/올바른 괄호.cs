using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
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
}