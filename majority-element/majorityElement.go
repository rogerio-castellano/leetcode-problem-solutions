func majorityElement(nums []int) int {
    result, count := nums[0], 0
    for _, num:= range nums {
        if(num == result) {
            count++
        } else {
            count--
            if(count == 0) {
                result = num
                count = 1
            }
        }
        if count > len(nums) / 2 {
            break
        }
    }

    return result
}