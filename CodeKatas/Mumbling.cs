using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas;
public class Mumbling
{
    public static String Accum(string s)
    {
        var formatted = "";
        for (int i = 0; i < s.Length; i++)
        {
            for (int y = 0; y <= i; y++)
            {
                if (i == 0 && y == 0)
                    formatted += (s[i].ToString().ToUpper());
                else if (y == 0)
                    formatted += ("-" + s[i].ToString().ToUpper());
                else
                    formatted += (s[i].ToString().ToLower());
            }

        }
        return formatted;
    }
}
