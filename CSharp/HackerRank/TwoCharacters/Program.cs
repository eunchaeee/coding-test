using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternate(string s)
    {
        int maxLen = 0;
        HashSet<char> uniqueChars = new HashSet<char>(s);

        var chars = uniqueChars.ToList();
        for (int i = 0; i < chars.Count; i++)
        {
            for (int j = i + 1; j < chars.Count; j++)
            {
                string filtered = new string(s.Where(c => c == chars[i] || c == chars[j]).ToArray());

                if (IsValid(filtered))
                {
                    maxLen = Math.Max(maxLen, filtered.Length);
                }
            }
        }
        return maxLen;
    }

    private static bool IsValid(string str)
    {
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == str[i - 1])
                return false;
        }
        return true;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "beabeefeab";
        int result = Result.alternate(s);
        Console.WriteLine(result);
    }
}