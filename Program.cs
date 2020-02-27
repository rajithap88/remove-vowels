/*
 Given a string S, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

Example 1:
Input: "leetcodeisacommunityforcoders"
Output: "ltcdscmmntyfrcdrs"

Example 2:
Input: "aeiou"
Output: ""

Note:
1.	S consists of lowercase English letters only.
2.	1 <= S.length <= 1000
*/
using System;

namespace E2_Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            string a1 = "aeioPu";
            string a = a1.ToLower();
            string r = "";
            for (int i = 0;i<a.Length;i++)
            {
                if(!((a[i] =='a') || (a[i] == 'e') || (a[i] == 'i') || (a[i] == 'o') || (a[i] == 'u')))
                {
                    r += a[i];

                }
            }
            Console.WriteLine(r);
        }
    }
}
