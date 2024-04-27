public class Solution
{
    public bool IsValid(string s)
    {
        var open = "";
        var pair = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var chr = s[i];
            if (new char[] { '(', '[', '{' }.Contains(chr))
            {
                stack.Push(chr);
            }

            if (new char[] { ')', ']', '}' }.Contains(chr))
            {
                pair.TryGetValue(chr, out char opening);
                if (stack.Count == 0 || opening != stack.Pop())
                    return false;
            }
        }

        return stack.Count == 0;
    }
}