using System;
using System.Text;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to
public class EncryptedWords
{
    static void Main(String[] args)
    {
        // Call findEncryptedWord with test cases here
    }

    public static String findEncryptedWord(String s)
    {
        // Write your code here        
        return EncryptWord(s);
    }

    private static string EncryptWord(string s)
    {
        
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        string res = string.Empty;

        int m = s.Length / 2 - (s.Length % 2 == 0 ? 1 : 0);
        string leftPart = s.Substring(0, m);
        string rightPart = s.Substring(m + 1, s.Length - m - 1);

        
        res += s[m];
        res += EncryptWord(leftPart);
        res += EncryptWord(rightPart);

        return res;
    }
}