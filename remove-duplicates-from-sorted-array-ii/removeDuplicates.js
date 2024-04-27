/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function (nums) {
  let result = 0,
    pointer = 0,
    count = 0,
    previous;
  nums.forEach((num) => {
    if (num != previous || count < 2) {
      nums[pointer++] = num;
      if (num != previous) {
        previous = num;
        count = 0;
      }
      result++;
    }
    count++;
  });
  return result;
};
