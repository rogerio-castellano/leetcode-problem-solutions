public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
            return 1;
        int temp = 0;
        int previous = 1;
        int result = 2;
        for (int i = 3; i <= n; i++)
        {
            temp = result;
            result += previous;
            previous = temp;
        }
        return result;
    }
}