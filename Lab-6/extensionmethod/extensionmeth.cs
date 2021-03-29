using calculatorlib;
using System;
using System.Collections.Generic;
using System.Text;

namespace extensionmethod
{
    public static class extensionmeth
    {
        public static int mul(this cal c)
        {
            return c.num1 * c.num2;
        }
        public static string str(this string s)
        {
            s = s.ToLower();
            int v = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='a'||s[i]=='e'||s[i]=='o'||s[i]=='u'||s[i]=='i')
                {
                    v += 1;
                }
                  
            }
            return v;
        }
    }
} 
