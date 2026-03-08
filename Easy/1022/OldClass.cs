//string input;
//input = Console.ReadLine();
////input = "root = [1,0,1,0,1,0,1]";
////input = "root = [0]";
//int index = input.IndexOf('[') + 1;
////Console.WriteLine(index);
//input = input.Substring(index, input.Length - index);
////Console.WriteLine(input);
//string[] strArr = input.Split(',', ']');
////foreach (var item in strArr)
////{
////    Console.WriteLine(item);
////}
//int count = strArr.Length - 1;
////Console.WriteLine(count);
//var queue = new Queue<TreeNode>(count);
//int poz = 0;
//var dict = new Dictionary<string, int>();
//var root = CreateNodeTreeAndSaveVal(strArr, poz++, count, "");
//while (poz < count)
//{
//    var node = queue.Dequeue();
//    node.left = CreateNodeTreeAndSaveVal(strArr, poz++, count, node.calcValStr);
//    if (poz < count)
//        node.right = CreateNodeTreeAndSaveVal(strArr, poz++, count, node.calcValStr);
//    else
//        break;
//}
//int result = 0;
//Calc(root);
////Console.WriteLine();
////Console.WriteLine("--");
//Console.WriteLine(result);

//void Calc(TreeNode node)
//{
//    if (node.left == null && node.right == null)
//    {
//        result += node.calcVal;
//    }
//    if (node.left != null)
//    {
//        Calc(node.left);
//    }
//    if (node.right != null)
//    {
//        Calc(node.right);
//    }
//}

//TreeNode CreateNodeTreeAndSaveVal(string[] strArr, int poz, int count, string calcValStr)
//{
//    var node = new TreeNode();
//    if (poz < count)
//    {
//        node.val = Convert.ToInt32(strArr[poz]);
//        if (string.IsNullOrEmpty(calcValStr))
//        {
//            node.calcValStr = node.val.ToString();
//        }
//        else
//        {
//            node.calcValStr = calcValStr + node.val.ToString();
//        }
//        node.calcVal = ToInt(node.calcValStr);
//        queue.Enqueue(node);
//        return node;
//    }
//    return null;
//}

//int ToInt(string calcValStr)
//{
//    int val = 0;
//    if (!dict.TryGetValue(calcValStr, out val))
//    {
//        int count = calcValStr.Length - 1;
//        int pow = 1;
//        for (int i = 0; i < calcValStr.Length; i++)
//        {
//            if (calcValStr[count - i] == '1')
//            {
//                val += pow;
//            }
//            pow *= 2;
//        }
//        dict[calcValStr] = val;
//    }
//    return val;
//}

//// Definition for a binary tree node.
//public class TreeNode
//{
//    public int val;
//    public int calcVal;
//    public string calcValStr;
//    public TreeNode left;
//    public TreeNode right;
//    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//    {
//        this.val = val;
//        this.left = left;
//        this.right = right;
//    }
//}

//public class Solution
//{
//    public int SumRootToLeaf(TreeNode root)
//    {
//        return 0;
//    }
//}