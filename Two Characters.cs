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
        int maxLength = 0;
    var uniqueChars = new HashSet<char>(s);

    
    foreach (char c1 in uniqueChars)
    {
        foreach (char c2 in uniqueChars)
        {
            if (c1 == c2) continue;

            char last = '\0';
            int length = 0;
            foreach (char c in s)
            {
                if (c == c1 || c == c2)
                {
                    if (c == last)
                    {
                        length = 0;
                        break;
                    }
                    length++;
                    last = c;
                }
            }
            if (length > maxLength) maxLength = length;
        }
    }

    return maxLength;


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = Result.alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
