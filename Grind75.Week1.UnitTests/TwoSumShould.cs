using FluentAssertions;

namespace Week1.UnitTests;

public class TwoSumShould
{
    [Theory]
    [InlineData(new[] { 0, 1, 1, 0 }, 3)]
    [InlineData(new[] { 1, 2, 3, 4 }, 100)]
    public void TwoSum_WhenNoPairAddsUpToTarget_ThrowInvalidOperationException(int[] nums, int target)
    {
        Assert.ThrowsAny<InvalidOperationException>(() => TwoSum.FindTwoSum2(nums, target));
    }
    
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] {0, 1})]
    [InlineData(new[] { 3 ,2, 4 }, 6, new[] {1, 2})]
    [InlineData(new[] { 3, 3 }, 6, new[] {0, 1})]
    public void TwoSum_WhenPairAddsUpToTarget_ReturnPair(int[] nums, int target, int[] expectedResult)
    {
        var result = TwoSum.FindTwoSum2(nums, target);
        result.Should().BeEquivalentTo(expectedResult);
    }
}