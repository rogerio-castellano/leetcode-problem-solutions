func isPalindrome(x int) bool {
   s := strconv.Itoa(x);
    start, end := 0, len(s) -1
    for start < end {
        if s[start] != s[end] {
            return false
        }
        start++
        end--
    }

   return true; 
}