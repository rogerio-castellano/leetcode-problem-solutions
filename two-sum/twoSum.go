func twoSum(nums []int, target int) []int {
    m:= make(map[int]int)

    for i:=0; i < len(nums) ; i++ {
        num := nums[i]
        compl := target - num
        index, found := m[compl]
        if found == true {
            return []int {index, i}
        }
        m[num] = i
    }

    return []int {math.MinInt64, math.MinInt64}
}