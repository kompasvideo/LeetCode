public class Solution2
{
    public static void Main()
    {
        //int[] nums = [2,7,11,15];
        int[] nums = [3, 2, 95, 4, -3];
        //int[] nums = [1,11,9,2,10,5,3,7,11,15];
        int target = 92;
        var sol = new Solution();
        var result = sol.TwoSum(nums, target);
        Console.WriteLine(result[0] + " " + result[1]);
    }


    public int[] TwoSum(int[] nums, int target)
    {
        var oneD = new Dictionary<int, int>(nums.Length);
        var two = new HashSet<int>(nums.Length);
        bool oneF = false;
        int[] result = new int[2];
        int min = 0;
        int minAbs = 0;
        if (target >= 0)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    minAbs = Math.Abs(nums[i]);
                }
                if (nums[i] <= (target + minAbs))
                {
                    if (!oneF)
                    {
                        oneF = true;
                        two.Add(target - nums[i]);
                        oneD[nums[i]] = i;
                    }
                    else
                    {
                        if (two.TryGetValue(nums[i], out var t))
                        {
                            result[1] = i;
                            result[0] = oneD[target - nums[i]];
                            break;
                        }
                        else
                        {
                            two.Add(target - nums[i]);
                            oneD[nums[i]] = i;
                        }
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (!oneF)
                {
                    oneF = true;
                    two.Add(target - nums[i]);
                    oneD[nums[i]] = i;
                }
                else
                {
                    if (two.TryGetValue(nums[i], out var t))
                    {
                        result[1] = i;
                        result[0] = oneD[target - nums[i]];
                        break;
                    }
                    else
                    {
                        two.Add(target - nums[i]);
                        oneD[nums[i]] = i;
                    }
                }
            }
        }
        return result;
    }
}