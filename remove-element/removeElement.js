/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function (nums, val) {
  let i = 0,
    iDest = 0,
    result = 0;

  while (i < nums.length) {
    if (nums[i] != val) {
      nums[iDest++] = nums[i];
      result++;
    }
    i++;
  }
  return result;
};
