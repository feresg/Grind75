namespace Week1.UnitTests;

public class BinarySearchShould
{
    [Theory]
    [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    public void Search_WhenItemIsInArray_ReturnIndex(int[] nums, int target, int expectedIndex)
    {
        Assert.Equal(expectedIndex, BinarySearch.Search(nums, target));
    }
    
    [Theory]
    [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 10)]
    public void Search_WhenItemIsNotInArray_ReturnMinusOne(int[] nums, int target)
    {
        Assert.Equal(-1, BinarySearch.Search(nums, target));
    }

}