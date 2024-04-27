func longestCommonPrefix(strs []string) string {
    var min = func(a,b int) int {
    if(a < b) { return a }
    return b
}
    result := strs[0]
    for i:= 1; i < len(strs); i++ {
        minlen := min(len(result), len(strs[i]))
        result = result[:minlen]
        for j:= 0; j < minlen; j++ {
            if(result[j] != strs[i][j]) {
                result = result[:j]
                break
            }
        }
    }

    return result
}
