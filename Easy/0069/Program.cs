public class Solution
{
    public static void Main()
    {
        //int a = 2147395599;
        int a = 4;
        var sol = new Solution();
        var result = sol.MySqrt(a);
        Console.WriteLine(result);
    }
    public int MySqrt(int x)       
    {
        uint right = 46340;
        uint left = 0;
        long middle = 0;
        while (right - left > 1)
        {
            middle = (right + left + 0l) / 2;
            if (middle * middle < x)
                left = (uint)middle;
            else
                right = (uint)middle;
        }
        if ((left + 1) * (left + 1) <= x)
            return (int)(left + 1);
        return (int)left;
    }
}