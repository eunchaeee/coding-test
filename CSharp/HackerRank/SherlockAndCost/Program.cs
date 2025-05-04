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
     * Complete the 'cost' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY B as parameter.
     */

    public static int cost(List<int> B)
    {
        int n = B.Count;
        int lowCost = 0;    // A[i]가 1일 때의 최대 cost        
        int highCost = 0;   // A[i]가 B[i]일 때의 최대 cost

        for (int i = 1; i < n; i++)
        {
            // 1. lowToLow
            // 이전 A[i-1] = 1 -> 현재 A[i] = 1
            int lowToLow = lowCost + 0;
            
            // 2. highToLow
            // 이전 A[i-1] = B[i-1] -> 현재 A[i] = 1
            int highToLow = highCost + Math.Abs(1 - B[i - 1]);
            
            // 3. lowToHigh
            // 이전 A[i-1] = 1 -> 현재 A[i] = B[i]
            int lowToHigh = lowCost + Math.Abs(B[i] - 1);
            
            // 4. highToHigh
            // 이전 A[i-1] = B[i-1] -> 현재 A[i] = B[i]
            int highToHigh = highCost + Math.Abs(B[i] - B[i - 1]);

            // 현재 A[i] = 1 일 때 최적 cost
            int newLowCost = Math.Max(lowToLow, highToLow);
            // 현재 A[i] = B[i] 일 때 최적 cost
            int newHighCost = Math.Max(lowToHigh, highToHigh);

            // 업데이트
            lowCost = newLowCost;
            highCost = newHighCost;
        }

        return Math.Max(lowCost, highCost);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            int result = Result.cost(B);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}