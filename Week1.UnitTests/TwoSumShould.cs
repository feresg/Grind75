namespace Week1.UnitTests;

public class TwoSumShould
{
    [Theory]
    [InlineData(new int[] { 0, 1, 1, 0 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 100)]
    public void TwoSum_WhenNoPairAddsUpToTarget_ThrowInvalidOperationException(int[] nums, int target)
    {
        Assert.ThrowsAny<InvalidOperationException>(() => TwoSum.FindTwoSum(nums, target));
    }
    
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] {0, 1})]
    [InlineData(new int[] { 3 ,2, 4 }, 6, new int[] {1, 2})]
    [InlineData(new int[] { 3, 3 }, 6, new int[] {0, 1})]
    public void TwoSum_WhenPairAddsUpToTarget_ReturnPair(int[] nums, int target, int[] expectedResult)
    {
        var result = TwoSum.FindTwoSum(nums, target);
        Assert.True(result.SequenceEqual(expectedResult));
    }

    


}