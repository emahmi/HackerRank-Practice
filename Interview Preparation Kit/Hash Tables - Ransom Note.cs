using System;
using System.Collections.Generic;

class Solution
{

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        var magazineDict = new Dictionary<string, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (!magazineDict.ContainsKey(magazine[i]))
            {
                magazineDict.Add(magazine[i], 1);
            }
            else
            {
                magazineDict[magazine[i]]++;
            }
        }

        for (int j = 0; j < note.Length; j++)
        {
            magazineDict.TryGetValue(note[j], out int value);

            if (value == 0)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                magazineDict[note[j]]--;
            }
        }

        Console.WriteLine("Yes");


    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}