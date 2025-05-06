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
     * Complete the 'insertionSort2' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort2(int n, List<int> arr)
    {
        for (int i = 1; i < arr.Count; i++)
        {
            int target = arr[i];
            for (int j = i - 1; j >= 0; j--)
            {
                if (arr[j] <= target)
                {
                    arr[j+1] = target;
                    break;
                }
                else
                {
                    arr[j + 1] = arr[j];
                }

                if (j == 0) arr[0] = target;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Result.insertionSort2(4, [3, 4, 7, 3]);
    }
}