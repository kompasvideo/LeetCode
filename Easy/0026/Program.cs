public class Solution
{
    public static void Main()
    {
        int[] nums = [1, 2, 4];
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
            if (nums[i] != n)
            {
                int t = nums[i];

                n = nums[i];
            }
            k++;
        }
        return 0;
    }
}