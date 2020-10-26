using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {
        var dictionaryS1 = new Dictionary<string, int>();

        for (int i = 0; i < s1.Length; i++)
        {
            if (!dictionaryS1.ContainsKey(s1[i].ToString()))
                dictionaryS1.Add(s1[i].ToString(), 0);
        }

        for (int j = 0; j < s2.Length; j++)
        {
            if (dictionaryS1.ContainsKey(s2[j].ToString()))
                return "YES";
        }

        return "NO";

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}