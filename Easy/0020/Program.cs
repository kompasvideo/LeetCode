public class Solution
{
    public static void Main()
    {
        //string s = "()";
        //string s = "()[]{}";
        //string s = "(]";
        //string s = "([])";
        string s = "([)]";
        var sol = new Solution();
        var result = sol.IsValid(s);
        Console.WriteLine(result);
    }
    public bool IsValid(string s)
    {
        Stack<int> stack = new Stack<int>();
        int l = 0;
        foreach (char c in s)
        {
            switch(c)
            {
                case '(':            
                    stack.Push(0);
                    break;
                case ')':
                    l = stack.Pop();
                    if(l != 0)
                    {
                        return false;
                    }
                    break;
                case '{':
                    stack.Push(1);
                    break;
                case '}':
                    l = stack.Pop();
                    if (l != 1)
                    {
                        return false;
                    }
                    break;
                case '[':
                    stack.Push(2);
                    break;
                case ']':
                    l = stack.Pop();
                    if (l != 2)
                    {
                        return false;
                    }
                    break;

            }
        }
        return true;
    }
}