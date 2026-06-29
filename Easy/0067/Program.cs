public class Solution
{
    public static void Main()
    {
        string a = "110010";
        string b = "10111";  // 1001001
        var sol = new Solution();
        var result = sol.AddBinary( a, b);
        Console.WriteLine(result);
    }
    public string AddBinary(string a, string b)
    {
        int ref_a = a.Length - 1;
        int ref_b = b.Length - 1;
        string result = "";
        bool is_p = false;
        while(true)
        {
            if (ref_a >= 0 && ref_b >= 0)
            {
                if (a[ref_a] == '1' && b[ref_b] == '1')
                {
                    if (is_p)
                        result = "1" + result;
                    else
                        result = "0" + result;
                    is_p = true;
                }
                if (a[ref_a] == '0' && b[ref_b] == '1')
                {
                    if (is_p)
                        result = "1" + result;
                    else
                        result = "1" + result;
                    is_p = false;
                }
                if (a[ref_a] == '1' && b[ref_b] == '0')
                {
                    if (is_p)
                        result = "1" + result;
                    else
                        result = "1" + result;
                    is_p = false;
                }
                if (a[ref_a] == '0' && b[ref_b] == '0')
                {
                    if (is_p)
                        result = "1" + result;
                    else
                        result = "0" + result;
                    is_p = false;
                }
                ref_a--;
                ref_b--;
            }
            else if (ref_a >= 0)
            {
                if (a[ref_a] == '1')
                {
                    if (is_p)
                    {
                        result = "0" + result;
                        is_p = true;
                    }
                    else
                    {
                        result = "1" + result;
                        is_p = false;
                    }
                }
                else
                {
                    if (is_p)
                    {
                        result = "1" + result;
                    }
                    else
                    {
                        result = "0" + result;
                    }
                    is_p = false;
                }
                ref_a--;
            }
            else if (ref_b >= 0)
            {
                if (b[ref_b] == '1')
                {
                    if (is_p)
                    {
                        result = "0" + result;
                        is_p = true;
                    }
                    else
                    {
                        result = "1" + result;
                        is_p = false;
                    }
                }
                else
                {
                    if (is_p)
                    {
                        result = "1" + result;
                    }
                    else
                    {
                        result = "0" + result;
                    }
                    is_p = false;
                }
                ref_b--;
            }
            else
            {
                if (is_p)
                    result = "1" + result;
                break;
            }
        }
        return result;
    }
}