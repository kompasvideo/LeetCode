public class Solution
{
    private static long[] p_pow;
    private static bool set = false;
    public static void Main()
    {
        var haystack = "sadbutsad";
        var needle = "sad";
        //var haystack = "leetcode";
        //var needle = "leeto";
        var sol = new Solution();
        var result = sol.StrStr(haystack, needle);
        Console.WriteLine(result);
    }
    public int StrStr(string haystack, string needle)
    {
        if (!set)
        {
            const int p = 237;
            p_pow = new long[10000];
            p_pow[0] = 1;
            for (int i = 1; i < p_pow.LongLength; i++)
            {
                p_pow[i] = p_pow[i - 1] * p;
            }
            set = true;
        }
        var h = new long[haystack.Length];
        for (int i = 0; i < haystack.Length; i++)
        {
            h[i] = (haystack[i]-'a' + 1) * p_pow[i];
            if (i > 0) h[i] += h[i - 1];
        }

        long h_s = 0;
        for (int i = 0; i < needle.Length; i++)
        {
            h_s += (needle[i] - 'a' + 1) * p_pow[i];            
        }

        for (int i = 0; i + needle.Length - 1 < haystack.Length; ++i)
        {
            long cur_h = h[i + needle.Length - 1];
            if (i > 0) cur_h -= h[i - 1];
            if (cur_h == h_s * p_pow[i])
                return i;
        }

        return -1;
    }
}