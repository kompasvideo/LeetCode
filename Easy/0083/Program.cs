//   Definition for singly-linked list.
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Solution
{
    public static void Main()
    {
        //int a = 2147395599;
        int[] b = [];
        var sol = new Solution();
        var a = CreateList(b);
        var result = sol.DeleteDuplicates(a);
        Print(result);
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode index1 = head;
        ListNode index2 = null;
        if (head == null)
            return head;
        if (head.next != null)
        {
            index2 = head.next;
        }
        else
            return head;

        while(index2.next != null)
        {
            if (index2.val == index1.val)
                index2 = index2.next;
            else
            {
                index1 = index1.next;
                index1.val = index2.val;
                index2 = index2.next;
            }
        }
        if (index1.val != index2.val)
            index1.next = index2;
        else
            index1.next = null;
        return head;
    }

    private static ListNode CreateList(int[] b)
    {
        ListNode outList = null;
        ListNode next = null;
        foreach (int item in b)
        { 
            if(next == null)
            {
                next = outList = new ListNode(item);
            }
            else
            {
                next.next = new ListNode(item);
                next = next.next;
            }
        }
        return outList;
    }

    private static void Print(ListNode result)
    {
        Console.Write($"{result.val} ");
        while(result.next != null)
        {
            result = result.next;
            Console.Write($"{result.val} ");
        }
        Console.WriteLine();
    }

}