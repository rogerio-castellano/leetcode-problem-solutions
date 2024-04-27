public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int result = nums[0];
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            result = Math.Max(sum, result);
            sum = Math.Max(0, sum);
        }

        return result;
    }
}