public class Solution
{
    public static void Main()
    {
        //int[] nums = [1, 1, 2];
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        var sol = new Solution();
        var result = sol.RemoveDuplicates(nums);
        Console.WriteLine(result);
    }

    public int RemoveDuplicates(int[] nums)
    {
        int k = 0;
        int n = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int t = nums[i];
            if (t != n)
            {
                nums[k++] = n;
                n = t;
            }
        }
        nums[k++] = n;
        return k;
    }
}