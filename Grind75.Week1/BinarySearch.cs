namespace Week1;

public static class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        var (low, high) = (0, nums.Length - 1);
        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1;
    }
}