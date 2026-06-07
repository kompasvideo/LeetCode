public class Solution
{
    public static void Main()
    {
        //int[] digits = [1, 2, 3];
        int[] digits = [9];
        var sol = new Solution();
        var result = sol.PlusOne(digits);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write("{0},",result[i]);
        }
        Console.WriteLine();
    }
    public int[] PlusOne(int[] digits)
    {
        int len = digits.Length;
        for (int i = len-1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                if(i==0)
                {
                    digits = new int[len + 1];
                    digits[0] = 1;
                    for (int j = 1; j < digits.Length; j++)
                    {
                        digits[j] = 0;
                    }
                    return digits;
                }
            }
            else
            {
                digits[i]++;
                break;
            }
        }
        return digits;
    }
}