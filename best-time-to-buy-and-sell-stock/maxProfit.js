/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  let left = 0;
  let right = 0;
  let maxProfit = 0;
  while (prices.length > right) {
    if (prices[right] > prices[left]) {
      let profit = prices[right] - prices[left];
      maxProfit = Math.max(maxProfit, profit);
    } else {
      left = right;
    }
    right++;
  }

  return maxProfit;
};
