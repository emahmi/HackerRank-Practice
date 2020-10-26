using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {
        int countAnagrams = 0;
        var dictionary = new Dictionary<string, int>();
        string key;

        for (int i = 1; i < s.Length; i++)
        {
            for (int j = 0; (i + j) <= s.Length; j++)
            {
                char[] keyArray = s.Skip(j).Take(i).ToArray();
                Array.Sort(keyArray);
                key = new string(keyArray);

                if (dictionary.TryGetValue(key, out int occur))
                {
                    countAnagrams += occur;
                    dictionary[key] = occur + 1;
                }
                else
                    dictionary.Add(key, 1);
            }
        }
        return countAnagrams;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();
            int result = sherlockAndAnagrams(s);
            textWriter.WriteLine(result);
        }
        textWriter.Flush();
        textWriter.Close();
    }
}
