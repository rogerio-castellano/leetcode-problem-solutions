public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        Dictionary<char, int> map = new() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

        for (int i = 0; i < s.Length - 1; i++)
        {
            var next = s[i + 1];

            if (map[s[i]] < map[next])
                result -= map[s[i]];
            else
                result += map[s[i]];
        }

        result += map[s[s.Length - 1]];

        return result;
    }
}