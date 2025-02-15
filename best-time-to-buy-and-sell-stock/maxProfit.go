func maxProfit(prices []int) int {
    var left, right, profit, maxProfit int

    for right < len(prices) {
        if(prices[right] > prices[left]) {
            profit = prices[right] - prices[left]
            maxProfit = max(profit, maxProfit)
        } else {
            left = right
        }
        
        right++
    }

    return maxProfit
}

func max(a int, b int) int {
    if(a > b) {
        return a
    }
    return b
}