public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var result = 0;
        var pointer = 0;
        foreach (var num in nums)
        {
            if (num != val)
            {
                nums[pointer++] = num;
                result++;
            }
        }
        return result;
    }
}