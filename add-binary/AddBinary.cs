public class Solution
{
    public string AddBinary(string a, string b)
    {
        var result = "";
        var carryOver = false;
        var lastIndex = 0;
        var digitA = '\0';
        var digitB = '\0';
        while (lastIndex < a.Length || lastIndex < b.Length)
        {
            if (lastIndex < a.Length)
                digitA = a[a.Length - lastIndex - 1];
            else
                digitA = '0';
            if (lastIndex < b.Length)
                digitB = b[b.Length - lastIndex - 1];
            else
                digitB = '0';

            if (digitA == digitB)
                result = (carryOver ? "1" : "0") + result;
            else
                result = (carryOver ? "0" : "1") + result;

            carryOver = (digitA == '1' && digitB == '1') || (carryOver && (digitA == '1' || digitB == '1'));
            lastIndex++;
        }
        result = (carryOver ? "1" : "") + result;

        return result;
    }
}