/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function (nums) {
  let result = nums[0];
  let count = 0;

  nums.forEach((num) => {
    if (num == result) {
      count++;
    } else {
      count--;
      if (count == 0) {
        result = num;
        count = 1;
      }
    }

    if (count > nums.Length / 2) {
      return result;
    }
  });

  return result;
};
