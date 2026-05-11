public class Solution
{
    public static void Main()
    {
        //int[] nums = [3, 2, 2, 3];
        //int[] nums = [1, 2, 2, 4];
        //int val = 3;
        //int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        //int val = 2;
        int[] nums = [0, 4, 4, 0, 4, 4, 4, 0, 2];
        int val = 4;
        var sol = new Solution();
        var result = sol.RemoveElement(nums, val);
        Console.WriteLine(result);
    }
    public int RemoveElement(int[] nums, int val)
    {
        int n = 0;
        int[] mas = new int[100];
        for (int i = 0; i < nums.Length; i++)
        {
            mas[nums[i]]++;
        }
        for (int i = 0; i < mas.Length; i++)
        {
            if (i == val)
                continue;
            for(int k = 0; k < mas[i]; k++)
            {
                nums[n++] = i;
            }
        }
        return n;
    }
    public int RemoveElementNoSort(int[] nums, int val)
    {
        int k = 0;
        int n = 0;
        bool f = true;
        for (int i = 0; i < nums.Length; i++)
        {
            int t = nums[i];
            if (t == val)
            {
                if (f)
                {
                    k = i;
                    f = false;
                }
            }
            else
            {
                f = true;
                nums[k] = t;
                if (k != i)
                    nums[i] = val;
                k++;
                n++;
            }
        }

        return n;
    }
}