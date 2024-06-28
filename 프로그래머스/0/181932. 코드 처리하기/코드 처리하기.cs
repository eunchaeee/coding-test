using System;

public class Solution {
    public string solution(string code) {
        int mode = 0;
        string ret = "";
        for (int i=0; i<code.Length; i++)
        {
            if (code[i].ToString() == "1")
            {
                mode = 1-mode;
                continue;
            }
            
            if (i%2==mode)
            {
                ret += code[i];
            }           
        }
        if (ret=="") ret="EMPTY";
        return ret;
    }
}