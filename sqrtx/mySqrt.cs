public class Solution
{
    public int MySqrt(int x)
    {
        var min = Convert.ToInt32("1000000000000".Substring(0, (x.ToString().Length + 1) / 2));
        for (int i = min; i <= min * 10; i++)
        {
            var sqr = i * i;
            if (sqr == x)
                return i;
            if (sqr > x || Math.Sign(sqr) == -1)
                return (i - 1);
        }

        throw new ArgumentException();
    }
}
