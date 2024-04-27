func merge(nums1 []int, m int, nums2 []int, n int)  {
    i, j := m-1, n-1
    k :=  m + n - 1

    for j >= 0 {
        if i >= 0 && nums1[i] > nums2[j] {
            nums1[k] = nums1[i]
            k--
            i--
        } else {
            nums1[k] = nums2[j]
            k--
            j--
        }
    }
}