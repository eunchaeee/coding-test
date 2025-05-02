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
     * Complete the 'insertionSort1' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY arr
     */

    public static void insertionSort1(int n, List<int> arr)
    {
        int target = arr[n - 1];
        for (int current = n - 1; current >= 0; current--)
        {
            if (current == 0)
            {
                arr[0] = target;
                Console.WriteLine(string.Join(' ', arr));
                break;
            }
            
            if (arr[current - 1] >= target)
            {
                arr[current] = arr[current - 1];
                Console.WriteLine(string.Join(' ', arr));
            }
            else
            {
                arr[current] = target;
                Console.WriteLine(string.Join(' ', arr));
                break;
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}

// 10
// 2 3 4 5 6 7 8 9 10 1