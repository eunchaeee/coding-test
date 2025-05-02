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
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        int mustAddCount = 6 - n > 0 ? 6 - n : 0;
        bool hasDigit = false;
        bool hasLower = false;
        bool hasUpper = false;
        bool hasSpecial = false;
        int hasType = 0;
        for (int i = 0; i < n; i++)
        {
            if (hasType == 4) break;
            
            if (!hasDigit && char.IsDigit(password[i]))
            {
                hasDigit = true;
                hasType++;
            }
            else if (!hasLower && char.IsLower(password[i]))
            {
                hasLower = true;
                hasType++;
            }
            else if (!hasUpper && char.IsUpper(password[i]))
            {
                hasUpper = true;
                hasType++;
            }
            else if (!hasSpecial && "!@#$%^&*()-+".Contains(password[i]))
            {
                hasSpecial = true;
                hasType++;
            }
        }

        return Math.Max(mustAddCount, 4 - hasType);
    }
    
        public static int minimumNumberFixed(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        bool hasDigit = false;
        bool hasLower = false;
        bool hasUpper = false;
        bool hasSpecial = false;
        for (int i = 0; i < n; i++)
        {
            if (char.IsDigit(password[i])) hasDigit = true;
            else if (char.IsLower(password[i])) hasLower = true;
            else if (char.IsUpper(password[i])) hasUpper = true;
            else if ("!@#$%^&*()-+".Contains(password[i])) hasSpecial = true;

            if (hasDigit && hasLower && hasUpper && hasSpecial) break;
        }

        int typeCount = 0;
        if (hasDigit) typeCount++;
        if (hasLower) typeCount++;
        if (hasUpper) typeCount++;
        if (hasSpecial) typeCount++;
        
        return Math.Max(6 - n, 4 - typeCount);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}