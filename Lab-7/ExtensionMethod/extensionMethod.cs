using System;
using calculatorLibrary;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class extensionmethods
    {
        public static int countVowels(this string s)
        {
            int vowels = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    vowels++;
                }
            }
            return vowels;

        }

        public static int mul(this Calculator c)
        {
            int res = c.Num1 * c.Num2;
            return res;
        }

    }
}