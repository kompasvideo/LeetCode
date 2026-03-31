public class Solution
{
    public static void Main()
    {
        //string[] s = ["flower", "flow", "flight"];
        string[] s = ["dog", "racecar", "car"];
        var sol = new Solution();
        string result;
        result = sol.LongestCommonPrefix(s);
        Console.WriteLine(result);
    }
    public string LongestCommonPrefix(string[] strs)
    {
        int len = 200;
        int k = 0;
        char p;
        while (true)
        {
            if (k < strs[0].Length)
            {
                p = strs[0][k];
            }
            else
                goto end;
            for (int i = 1; i < strs.Length; i++)
            {
                if (k >= strs[i].Length)
                {
                    goto end;
                }
                if (strs[i][k] != p)
                    goto end;
            }
            k++;
        }
      end:
        return strs[0].Substring(0, k);
    }
    //public string LongestCommonPrefix(string[] strs)
    //{
    //    long p = 237;
    //    long[] p_pow = new long[200];
    //    p_pow[0] = p;
    //    for (int i = 1; i < p_pow.Length; i++)
    //    {
    //        p_pow[i] = p_pow[i - 1] * p;
    //    }

    //    long[,] h = new long[200, 200];
    //    for (int i = 0; i < strs.Length; i++)
    //    {
    //        for (int k = 0; k < strs[i].Length; k++)
    //        {
    //            char c = strs[i][k];
    //            h[i, k] = (c - 'a' + 1) * p_pow[k];
    //            if (k > 0) h[i, k] += h[i, k - 1];
    //        }
    //    }

    //    return "";
    //}
}