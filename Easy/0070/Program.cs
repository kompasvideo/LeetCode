using System.Runtime.ConstrainedExecution;

public class Solution
{
    public static void Main()
    {
        //int a = 2147395599;
        int a = 2;
        var sol = new Solution();
        var result = sol.ClimbStairs(a);
        Console.WriteLine(result);
    }
    public int ClimbStairs(int n)
    {
        if (n <= 0)
            return 1;
        else if (n == 1)
            return 1;

        int a = 1, b = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}

