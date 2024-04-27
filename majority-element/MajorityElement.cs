public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var result = nums[0];
        var count = 0;

        foreach (var num in nums)
        {
            if (num == result)
            {
                count++;
            }
            else
            {
                count--;
                if (count == 0)
                {
                    result = num;
                    count = 1;
                }
            }

            if (count > nums.Length / 2)
            {
                break;
            }
        }

        return result;
    }
}