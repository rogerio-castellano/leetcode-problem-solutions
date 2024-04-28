/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function (nums, k) {
  var reverse = (arr, start, end) => {
    while (start < end) {
      let temp = arr[start];
      arr[start++] = arr[end];
      arr[end--] = temp;
    }
  };

  k = k % nums.length;
  reverse(nums, nums.length - k, nums.length - 1);
  reverse(nums, 0, nums.length - 1);
  reverse(nums, k, nums.length - 1);
};
