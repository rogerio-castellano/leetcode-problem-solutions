public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var word = "";
        var previous = '\0';
        var current = '\0';
        for (int i = 0; i < s.Length; i++)
        {
            current = s[i];
            if (previous != ' ' && current != ' ')
                word = word + current;

            if (previous == ' ' && current != ' ')
                word = current.ToString();

            previous = current;
        }

        return word.Length;
    }
}