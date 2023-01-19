namespace Week1;

public static class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j };
                }
            }
        }

        throw new InvalidOperationException();
    }
}