namespace Week1;

public class Anagram
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var freq = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (freq.ContainsKey(c))
            {
                freq[c]++;
            }
            else
            {
                freq[c] = 1;
            }
        }

        foreach (var c in t)
        {
            if (!freq.ContainsKey(c)) return false;
            freq[c]--;
            if (freq[c] == 0)
            {
                freq.Remove(c);
            }
        }

        return !freq.Any();
    }
}