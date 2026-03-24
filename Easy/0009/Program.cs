public class Solution
{
    public static void Main()
    {
        int x = 10;
        var sol = new Solution();
        bool result;
        result = sol.IsPalindrome(x);
        Console.WriteLine(result);
    }
    public bool IsPalindrome(int x)
    {
        int[] mas = new int[64];
        int i = 0;
        if (x < 0)
        {
            return false;
        }
        while (true)
        {
            mas[i++] = x % 10;
            if (x >= 10)
                x = x / 10;
            else
                break;
        }
        i--;
        int k = 0;
        while (true)
        {
            if (i < k)
            {
                if (k - i == 1)
                    return true;
                return false;
            }
            if (mas[i] != mas[k])
                return false;
            if (i == k)
                return true;
            i--;
            k++;
        }
    }
}