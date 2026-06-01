public class Solution
{
    public static void Main()
    {
        string s = "Today is a nice day";
        //string s = "   fly me   to   the moon  ";
        var sol = new Solution();
        var result = sol.LengthOfLastWord(s);
        Console.WriteLine(result);
    }
    public int LengthOfLastWord(string s)
    {
        int i = 0;
        int res = 0;
        foreach (var c in s)
        {
            if (c == ' ')
            {
                if (i > 0)
                {
                    res = i;
                    i = 0;
                }
            }          
            else i++;
        }
        if (i > 0)
            return i;
        return res;
    }
}