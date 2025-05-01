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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string answer;
        if (s.EndsWith("AM") && s.CompareTo("12:00:00AM") >= 0 && s.CompareTo("12:59:59AM") <= 0)
        {
            int.TryParse(s.Substring(0, 2), out int t);
            string h;
            if (t - 12 < 10)
            {
                h = $"0{t - 12}";
            }
            else
            {
                h = $"{t - 12}";
            }
            answer = $"{h}{s.Substring(2,6)}";
        }
        else if (s.EndsWith("PM") && s.CompareTo("01:00:00PM") >= 0 && s.CompareTo("11:59:59PM") <= 0)
        {
            int.TryParse(s.Substring(0, 2), out int t);
            answer = $"{t + 12}{s.Substring(2,6)}";
        }
        else
        {
            answer = s.Substring(0, 8);
        }
        return answer;
    }

    public static string timeConversionGPT(string s)
    {
        int hour = int.Parse(s.Substring(0, 2));
        string minuteSec = s.Substring(2, 6);
        string period = s.Substring(8, 2);

        if (period == "AM")
        {
            if (hour == 12) hour = 0;
        }
        else
        {
            if (hour != 12) hour += 12;
        }

        return $"{hour:D2}{minuteSec}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = "07:05:45PM";
        Console.WriteLine(Result.timeConversionGPT(s));
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string s = Console.ReadLine();
        // string result = Result.timeConversion(s);
        //
        // textWriter.WriteLine(result);
        //
        // textWriter.Flush();
        // textWriter.Close();
    }
}