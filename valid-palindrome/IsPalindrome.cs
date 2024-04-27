public class Solution
{
    public bool IsPalindrome(string s)
    {
        var lower = s.ToLower();
        StringBuilder sbOnlyLetterOrDigit = new StringBuilder();
        foreach (char c in lower.ToCharArray())
            if (Char.IsLetterOrDigit(c))
                sbOnlyLetterOrDigit.Append(c.ToString());

        string onlyLetterOrDigit = sbOnlyLetterOrDigit.ToString();
        var start = 0;
        var end = onlyLetterOrDigit.Length - 1;

        while (start < end)
        {
            if (onlyLetterOrDigit[start] != onlyLetterOrDigit[end])
                return false;

            start++;
            end--;
        }
        return true;
    }
}