func removeDuplicates(nums []int) int {
    previous, result, pointer := math.MaxInt32, 0, 0
    
    for _, v := range nums {
        if(v != previous) {
            nums[pointer] = v
            previous = v
            pointer++
            result++
        }
    }

    return result
}
