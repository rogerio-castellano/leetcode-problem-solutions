/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function (nums) {
  let p = 0,
    result = 0,
    previous;
  nums.forEach((element) => {
    if (element != previous) {
      nums[p++] = element;
      previous = element;
      result++;
    }
  });
  return result;
};
