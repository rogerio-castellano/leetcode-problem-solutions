public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        var result = new List<int>();
        var counts = words.GroupBy(w => w)
            .Select(s => new { word = s.Key, Count = s.Count() })
            .ToDictionary(g => g.word, g => g.Count);
        var n = s.Length;
        var num = words.Length;
        var len = words[0].Length;

        for (int i = 0; i < n - num * len + 1; i++)
        {
            var seen = new Dictionary<string, int>();
            var j = 0;
            while (j < num)
            {
                var word = s.Substring(i + j * len, len);
                if (counts.ContainsKey(word))
                {
                    seen[word] = seen.GetValueOrDefault(word, 0) + 1;
                    if (seen[word] > counts.GetValueOrDefault(word, 0))
                        break;
                }
                else
                    break;
                j++;
            }

            if (j == num)
                result.Add(i);
        }

        return result;
    }
}