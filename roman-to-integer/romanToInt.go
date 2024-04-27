func romanToInt(s string) int {
    result := 0
    roman := map[byte]int{
        'I' : 1,
        'V' : 5,
        'X' : 10,
        'L' : 50,
        'C' : 100,
        'D' : 500,
        'M' : 1000,
    }

    fmt.Println(roman)
    for i := 0 ; i < len(s) - 1; i++  {
        if(roman[s[i]] < roman[s[i + 1]]) {
            result -= roman[s[i]]
        } else {
            result += roman[s[i]]
        }
    }

    result += roman[s[len(s) - 1]]

    return result
}
