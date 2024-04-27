public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            var compl = target - nums[i];
            if (dict.ContainsKey(compl))
                return new int[2] { dict[compl], i };
            else
                dict.TryAdd(nums[i], i);
        }
        return new int[2];
    }
}