public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var result = 0;
        var length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            result = i;
            if (nums[i] >= target)
                break;
        }
        if (nums[length - 1] < target)
            result++;

        return result;
    }
}