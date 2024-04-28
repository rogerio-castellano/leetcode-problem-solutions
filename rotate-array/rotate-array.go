func rotate(nums []int, k int)  {
    k = k % len(nums)
    slices.Reverse(nums[len(nums) - k:])
    slices.Reverse(nums)
    slices.Reverse(nums[k:])
}