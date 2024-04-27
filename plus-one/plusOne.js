public class Solution {
    public int[] PlusOne(int[] digits) {
        var result = new int[digits.Length];
        var biggerResult = new int[digits.Length + 1];
        var value = 0;
        var carryOver = false;

        for(int i = digits.Length - 1; i >=0; i--)
        {
            value = digits[i];
            
            if(carryOver || i == digits.Length - 1) 
                value++;

            result[i] = value % 10;
            carryOver = value >= 10;
        }
        
        if(carryOver)
        {
            biggerResult[0] = 1;
            Array.Copy(result,0,biggerResult,1, result.Length);
            return biggerResult;
        }            
            
        return result;
    }
}