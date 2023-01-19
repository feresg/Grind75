namespace Week1.UnitTests;

public class AnagramShould
{
    [Theory]
    [InlineData("rat", "cart")]
    public void IsAnagram_WhenStringsHaveDifferentLength_ReturnFalse(string s, string t)
    {
        Assert.False(Anagram.IsAnagram(s, t));
    }
    
    [Theory]
    [InlineData("rat", "car")]
    public void IsAnagram_WhenStringsAreNotAnagrams_ReturnFalse(string s, string t)
    {
        Assert.False(Anagram.IsAnagram(s, t));
    }
    
    [Theory]
    [InlineData("anagram", "nagaram")]
    public void IsAnagram_WhenStringsAreAnagrams_ReturnTrue(string s, string t)
    {
        Assert.True(Anagram.IsAnagram(s, t));
    }
}