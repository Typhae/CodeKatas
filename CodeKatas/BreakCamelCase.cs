using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas
{
    public static class BreakCamelCase
    {
        public static string CamelCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    str = str.Insert(i, " ");
                    i++;
                }
            }
            return str;
        }
    }
}
