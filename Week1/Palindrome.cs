using System.Text;

namespace Week1;

public static class Palindrome
{
    public static bool IsPalindrome(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9')
            {
                sb.Append(char.ToLower(c));
            };
        }

        var length = sb.Length;

        for (var i = 0; i < length / 2; i++)
        {
            if (sb[i] != sb[length - i - 1])
            {
                return false;
            }
        }
        
        return true;
    }

    
}