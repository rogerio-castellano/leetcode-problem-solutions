/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
  let map = {};
  for (let i = 0; i < nums.length; i++) {
    let num = nums[i];
    let compl = target - nums[i];
    if (map[compl] || map[compl] === 0) return [map[compl], i];

    map[num] = i;
  }
};
