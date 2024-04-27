public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var next = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[next] = nums[i];
                if (i != next)
                    nums[i] = 0;

                next++;
            }
        }
        return;
    }
}