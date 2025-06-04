namespace Week1;

public static class Anagram
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var freq = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!freq.TryAdd(c, 1))
            {
                freq[c]++;
            }
        }

        foreach (var c in t)
        {
            if (!freq.TryGetValue(c, out int value)) return false;
            freq[c] = --value;
            if (value == 0)
            {
                freq.Remove(c);
            }
        }

        return freq.Count == 0;
    }
}