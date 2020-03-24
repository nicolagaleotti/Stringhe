using System;
using System.Runtime;

namespace EserciziStringhe
{
    public class Metodi
    {
        public static bool AreEquals (string s1, string s2) //pag. 262 numero 1
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }

        public static bool ContainsDoubleChar(string s) //pag. 262 numero 2
        {
            int maiuscole = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]) == true)
                    maiuscole++;
            }
            if (maiuscole > 0)
                return true;
            else 
                return false;
        }

        public static string Convert (string s) //pag. 262 numero 11
        {
            for (int i = 0; i < s.Length - 1; i ++)
            {
                if (i == 0)
                    Char.ToUpper(s[i]);
                if (s[i] == ' ')
                {
                    Char.ToUpper(s[i + 1]);
                }
                else
                {
                    Char.ToLower(s[i + 1]);
                }
            }
            return s;
        }
    }
}
