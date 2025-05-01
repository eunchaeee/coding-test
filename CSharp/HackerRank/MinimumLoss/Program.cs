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
     * Complete the 'minimumLoss' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts LONG_INTEGER_ARRAY price as parameter.
     */

    // 시간초과(O(n제곱))
    public static int minimumLoss(List<long> price)
    {
        long minimumLoss = 987654321;
        for (int buy = 0; buy < price.Count - 1; buy++)
        {
            for (int sell = buy + 1; sell < price.Count; sell++)
            {
                Console.WriteLine($"{buy}, {sell}");
                long diff = price[buy] - price[sell];
                if (diff > 0 && minimumLoss > diff)
                {
                    minimumLoss = diff;
                }
            }
        }

        return (int)minimumLoss;
    }

    public static int minimumLossGPT(List<long> price)
    {
        Dictionary<long, int> yearMap = new Dictionary<long, int>();
        for (int i = 0; i < price.Count; i++)
            yearMap[price[i]] = i;
        
        price.Sort();

        long minLoss = long.MaxValue;

        for (int i = 1; i < price.Count; i++)
        {
            long higher = price[i];
            long lower = price[i - 1];

            if (yearMap[higher] < yearMap[lower])
            {
                long diff = higher - lower;
                if (diff < minLoss)
                    minLoss = diff;
            }
        }

        return (int)minLoss;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Result.minimumLossGPT([20, 7, 8, 2, 5]));
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        //
        // int n = Convert.ToInt32(Console.ReadLine().Trim());
        //
        // List<long> price = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(priceTemp => Convert.ToInt64(priceTemp)).ToList();
        //
        // int result = Result.minimumLoss(price);
        //
        // textWriter.WriteLine(result);
        //
        // textWriter.Flush();
        // textWriter.Close();
    }
}