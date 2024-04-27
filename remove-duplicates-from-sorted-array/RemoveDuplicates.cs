public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var result = 0;
        var pointer = 0;
        var previous = int.MinValue;

        foreach (var num in nums)
        {
            if (num != previous)
            {
                nums[pointer++] = num;
                previous = num;
                result++;
            }
        }

        return result;
    }
}