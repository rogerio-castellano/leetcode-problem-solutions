public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var result = 0;
        var pointer = 0;
        var previous = int.MinValue;
        var count = 0;

        foreach (var num in nums)
        {
            if (num != previous || count < 2)
            {
                nums[pointer++] = num;
                result++;
                if (num != previous)
                {
                    previous = num;
                    count = 0;
                }
            }
            count++;
        }

        return result;
    }
}