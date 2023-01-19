namespace Week1.UnitTests;

public class PalindromeShould
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama")]
    [InlineData(" ")]
    public void IsPalindrome_IfValid_ReturnTrue(string s)
    {
        Assert.True(Palindrome.IsPalindrome(s));
    }
    
    [Theory]
    [InlineData("race a car")]
    public void IsPalindrome_IfInvalid_ReturnFalse(string s)
    {
        Assert.False(Palindrome.IsPalindrome(s));
    }
}