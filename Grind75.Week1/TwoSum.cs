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
                    return [i, j];
                }
            }
        }

        throw new InvalidOperationException();
    }
    
    public static int[] FindTwoSum2(int[] nums, int target) {
        var valueIndexMap = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var remainder = target - nums[i];
            if (valueIndexMap.TryGetValue(remainder, out var indexRemainder))
            {
                return [i, indexRemainder];
            }
            
            valueIndexMap[nums[i]] = i;
        }
        
        throw new InvalidOperationException("No two sum found");
    }

}