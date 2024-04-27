func removeDuplicates(nums []int) int {
    var result, pointer, count int
    previous :=  math.MinInt32

    for _, num := range nums {
        if num != previous || count < 2 {
            nums[pointer] = num
            pointer++
            if num != previous {
                previous = num
                count = 0
            }
            result++
        }
        count++
    }

    return result
}