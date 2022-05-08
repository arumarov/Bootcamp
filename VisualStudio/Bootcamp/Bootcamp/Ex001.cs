using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    public class Ex001
    {
        public static string ClearString(string s)
        {
            string result = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (
                    s[i] == '1'
                    || s[i] == '2'
                    || s[i] == '3'
                    || s[i] == '4'
                    || s[i] == '5'
                    || s[i] == '6'
                    || s[i] == '7'
                    || s[i] == '8'
                    || s[i] == '9'
                    || s[i] == '0'
                ) { }
                else result = result + $"{s[i]}";
            }
            return result;
        }

    }
}
