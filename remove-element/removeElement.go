func removeElement(nums []int, val int) int {
  var p, result int

    for _, num := range nums {
        if(num != val) {
            nums[p] = num
            p++
            result++
        }
    }

  return result
}