public class Solution
{
    static Dictionary<string, int> dict;
    static TreeNode root;
    static int result;
    static Queue<TreeNode> queue;

    public static void Main()
    {
        string input;
        //input = Console.ReadLine();
        input = "root = [1,0,1,0,1,0,1]";
        //input = "root = [0]";
        int index = input.IndexOf('[') + 1;
        Console.WriteLine(index);
        input = input.Substring(index, input.Length - index);
        Console.WriteLine(input);
        string[] strArr = input.Split(',', ']');
        foreach (var item in strArr)
        {
            Console.WriteLine(item);
        }
        int count = strArr.Length - 1;
        Console.WriteLine(count);
        queue = new Queue<TreeNode>(count);
        int poz = 0;
        dict = new Dictionary<string, int>();
        root = CreateNodeTreeAndSaveVal(strArr, poz++, count);
        while (poz < count)
        {
            var node = queue.Dequeue();
            node.left = CreateNodeTreeAndSaveVal(strArr, poz++, count);
            if (poz < count)
                node.right = CreateNodeTreeAndSaveVal(strArr, poz++, count);
            else
                break;
        }
        result = 0;
        var sol = new Solution();
        result = sol.SumRootToLeaf(root);
        Console.WriteLine();
        Console.WriteLine("--");
        Console.WriteLine(result);
    }

    static TreeNode CreateNodeTreeAndSaveVal(string[] strArr, int poz, int count)
    {
        var node = new TreeNode();
        if (poz < count)
        {
            node.val = Convert.ToInt32(strArr[poz]);
            queue.Enqueue(node);
            return node;
        }
        return null;
    }

    // Definition for a binary tree node. 
    public int SumRootToLeaf(TreeNode root)
    {
        int result = 0;
        Calc(root, 0, ref result);
        return result;
    }
    void Calc(TreeNode node, int val, ref int result)
    {
        if (node.left == null && node.right == null)
        {
            result += val * 2 + node.val;
        }
        if (node.left != null)
        {
            Calc(node.left, val * 2 + node.val, ref result);
        }
        if (node.right != null)
        {
            Calc(node.right, val * 2 + node.val, ref result);
        }
    }

}
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
