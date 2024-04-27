func isValid(s string) bool {
    myStack := [] rune {}
    openingBrackets := map[rune] bool { '(' : true, '[' : true, '{' : true}
    bracketPairs := map[rune]rune {')' : '(', ']' : '[', '}' : '{'}

    for _, r := range s {
        if openingBrackets[r] == true {
            myStack = append(myStack, r)
        } else {
            rOpening := bracketPairs[r]
            if(len(myStack) > 0 && rOpening == myStack[len(myStack) - 1]) {
                myStack = myStack[:len(myStack) - 1]
            } else {
                return false
            }

        } 
    }
    return len(myStack) == 0
}