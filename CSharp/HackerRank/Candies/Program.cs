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
     * Complete the 'candies' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static long candies(int n, List<int> arr)
    {
        int[] candies = new int[n];
        
        // 1개 씩 주기
        for (int i = 0; i < n; i++)
        {
            candies[i] = 1;
        }
        
        // 왼쪽 -> 오른쪽 : 오른쪽이 더 크면 오른쪽에 사탕 하나 더주기
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                candies[i] = candies[i-1] + 1;
            }
        }
        
        // 오른쪽 -> 왼쪽 : 오른쪽이 더 작으면 왼쪽에 사탕 하나 더주기
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i + 1] < arr[i])
            {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }

        long answer = 0;
        foreach (int c in candies)
        {
            answer += c;
        }

        return answer;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        long result = Result.candies(n, arr);
        Console.WriteLine(result);
        // textWriter.WriteLine(result);
        //
        // textWriter.Flush();
        // textWriter.Close();
    }
}