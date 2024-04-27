public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }

    public bool ContainsDuplicateV1(int[] nums)
    {
        var l = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!l.Contains(nums[i]))
                l.Add(nums[i]);
            else
                return true;
        }
        return false;
    }
}