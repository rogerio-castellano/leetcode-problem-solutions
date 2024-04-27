public class Solution {
    public int Reverse(int x) {
        var signal = Math.Sign(x) == -1 ? "-" : "" ;
        var array = x.ToString().Replace("-", "").ToCharArray();

        Array.Reverse(array);
        var str = new string(array);
        var firstDigits = 0;
        if(str.Length == 10)
        {
            firstDigits = int.Parse(str.Substring(0,9));
            var lastDigit = int.Parse(str.Substring(8,1));
            if(firstDigits == 214748364)
            {
                if((signal == "-" && lastDigit > 8 ) || (signal == "" && lastDigit > 7))
                    return 0;
            }

            if (firstDigits > 214748364)
                return 0;
        }
        return int.Parse(signal + str);
    }
}