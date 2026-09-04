public class Solution
{
    public static void Main()
    {
        int[] nums1 = [0];
        int m = 0;
        int[] nums2 = [1];
        int n = 1;
        var sol = new Solution();
        sol.Merge(nums1, m, nums2, n);
        Print(nums1);
    }

    private static void Print(int[] nums1)
    {
        foreach (var i in nums1)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;
        
        while (j >= 0) {
            if (i >= 0 && nums1[i] > nums2[j]) {
                nums1[k--] = nums1[i--];
            } else {
                nums1[k--] = nums2[j--];
            }
        }
    }
}