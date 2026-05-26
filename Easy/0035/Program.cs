using System.Reflection;

public class Solution
{
    private static long[] p_pow;
    private static bool set = false;
    public static void Main()
    {
        int[] nums = [1, 3, 5, 6];
        //var target = 5;
        var target = 0;
        var sol = new Solution();
        var result = sol.SearchInsert(nums, target);
        Console.WriteLine(result);
    }
    public int SearchInsert(int[] nums, int target)
    {
        int left = -1;
        int right = nums.Length;
        while(right - left > 1)
        {
            int middle = (right + left) / 2;
            if (nums[middle] < target)
                left = middle;
            else
                right = middle;
        }
        return left + 1;
    }
}