public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var result = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            var minLength = Math.Min(result.Length, strs[i].Length);
            var length = 0;
            for (int j = 0; j < minLength; j++)
                if (result[j] == strs[i][j])
                    length++;
                else
                    break;

            if (length == 0)
                return "";
            result = result.Substring(0, length);
        }
        return result;
    }
}