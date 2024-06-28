using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string result = my_string.Remove(s, overwrite_string.Length);
        result = result.Insert(s, overwrite_string);
        return result;
    }
}