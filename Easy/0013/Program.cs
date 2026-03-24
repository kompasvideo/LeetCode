public class Solution
{
    public static void Main()
    {
        //string s = "CCCXCIX";
        string s = "MD";
        var sol = new Solution();
        int result;
        result = sol.RomanToInt(s);
        Console.WriteLine(result);
    }
    public int RomanToInt(string s)
    {
        int len = s.Length;
        char old = ' ';
        int oldC = 0;
        int result = 0;
        for (int i = len - 1; i >= 0; i--)
        {
            char c = s[i];
            switch (c)
            {
                case 'I':
                    if(oldC == 0)
                    {
                        old = c;
                        result = 1;
                        oldC++;
                    }
                    else if (old == 'V')
                    {
                        old = c;
                        result -= 1;
                        oldC = 1;
                    }
                    else if (old == 'X')
                    {
                        old = c;
                        result -= 1;
                        oldC = 1;
                    }
                    else
                    {
                        old = c;
                        result++;
                        oldC++;
                    }
                    break;
                case 'V':
                    if (oldC == 0)
                    {
                        old = c;
                        result = 5;
                        oldC++;
                    }
                    else if(old == 'I')
                    {
                        old = c;
                        result += 5;
                        oldC = 1;
                    }
                    else
                    {
                        old = c;
                        result += 5;
                        oldC++;
                    }
                    break;
                case 'X':
                    if (oldC == 0)
                    {
                        old = c;
                        result = 10;
                        oldC++;
                    }
                    else if (old == 'I')
                    {
                        old = c;
                        result += 10;
                        oldC = 1;
                    }
                    else if (old == 'L')
                    {
                        old = c;
                        result -= 10;
                        oldC = 1;
                    }
                    else if (old == 'C')
                    {
                        old = c;
                        result -= 10;
                        oldC = 1;
                    }
                    else
                    {
                        old = c;
                        result += 10;
                        oldC++;
                    }
                    break;
                case 'L':
                    if (oldC == 0)
                    {
                        old = c;
                        result = 50;
                        oldC++;
                    }
                    else
                    {
                        old = c;
                        result += 50;
                        oldC++;
                    }
                    break;
                case 'C':
                    if (oldC == 0)
                    {
                        old = c;
                        result = 100;
                        oldC++;
                    }
                    else if (old == 'D')
                    {
                        old = c;
                        result -= 100;
                        oldC = 1;
                    }
                    else if (old == 'M')
                    {
                        old = c;
                        result -= 100;
                        oldC = 1;
                    }
                    else
                    {
                        old = c;
                        result += 100;
                        oldC++;
                    }
                    break;
                case 'D':
                    if (oldC == 0)
                    {
                        old = c;
                        result = 500;
                        oldC++;
                    }
                    else
                    {
                        old = c;
                        result += 500;
                        oldC++;
                    }
                    break;
                case 'M':
                    if (oldC == 0)
                    {
                        old = c;
                        result = 1000;
                        oldC++;
                    }
                    else
                    {
                        old = c;
                        result += 1000;
                        oldC++;
                    }
                    break;
            }
        }
        return result;
    }
}