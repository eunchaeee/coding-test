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
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        int maxLen = s.Length / 2;
        bool isBeautiful = false;
        for (int len = 1; len <= maxLen; len++)
        {
            string first = s.Substring(0, len);

            if (first.StartsWith("0")) continue;
            
            string built = first;
            long num = long.Parse(first);
            //Console.WriteLine($"length : {length}, firstNum : {firstNum}");
            
            while (built.Length < s.Length)
            {
                num += 1;
                built += num.ToString();
                //Console.WriteLine($"beautiful string: {beautifulString}");
            }

            if (built == s)
            {
                Console.WriteLine($"YES {s.Substring(0, len)}");
                isBeautiful = true;
                break;
            }
        }
        
        if (!isBeautiful) 
            Console.WriteLine("NO");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}