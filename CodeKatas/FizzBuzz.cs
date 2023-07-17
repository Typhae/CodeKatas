namespace CodeKatas;

using System;
using System.Collections.Generic;
using System.Linq;

public class FizzBuzz
{
    public static string[] GetFizzBuzzArray(int n)
    {
        int[] fizzyness = new int[n];
        for (int i = 0; i < n; i++)
        {
            fizzyness[i] = i + 1;
        }
        string[] buzzyness = new string[n];

        for (int i = 0; i < n; i++)
        {
            if (fizzyness[i] % 5 == 0 && fizzyness[i] % 3 == 0)
            {
                buzzyness[i] = "FizzBuzz";
            }
            else if (fizzyness[i] % 3 == 0)
            {
                buzzyness[i] = "Fizz";
            }
            else if (fizzyness[i] % 5 == 0)
            {
                buzzyness[i] = "Buzz";
            }

            else buzzyness[i] = fizzyness[i].ToString();
        }
        return buzzyness;


    }
}
