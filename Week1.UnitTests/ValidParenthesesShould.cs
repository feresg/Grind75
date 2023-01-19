namespace Week1.UnitTests;

public class ValidParenthesesShould
{
    [Theory]
    [InlineData("[]{}(()")]
    public void IsValid_WhenStringLengthIsOdd_ReturnFalse(string s)
    {
        Assert.False(ValidParentheses.IsValid(s));
    }
    
    [Theory]
    [InlineData("a[{b((")]
    [InlineData("[]{!((")]
    [InlineData("[1{!(1")]
    public void IsValid_WhenStringContainsInvalidCharacters_ThrowInvalidOperationException(string s)
    {
        Assert.Throws<InvalidOperationException>(() => ValidParentheses.IsValid(s));
    }
    
    [Theory]
    [InlineData("(]")]
    [InlineData("()[]{[")]
    public void IsValid_WhenStringHasInvalidParentheses_ReturnFalse(string s)
    {
        Assert.False(ValidParentheses.IsValid(s));
    }

    [Theory]
    [InlineData("()")]
    [InlineData("()[]{}")]
    public void IsValid_WhenStringHasValidParentheses_ReturnTrue(string s)
    {
        Assert.True(ValidParentheses.IsValid(s));
    }
}