// Definition for singly-linked list.
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
        //ListNode  list1 = Create(0);
        //ListNode list2 = Create();
        ListNode  list1 = Create(1, 2, 4);
        ListNode  list2 = Create(1, 3, 4);
        var sol = new Solution();
        var result = sol.MergeTwoLists(list1, list2);
        Print(result);
    }

    private static void Print(ListNode result)
    {
        Console.Write("[ ");
        if (result != null)
        {
            while (result != null)
            {
                Console.Write($"{result.val}, ");
                result = result.next;
            }
            Console.Write("\b\b");
        }
        Console.WriteLine("]");
    }

    private static ListNode Create(params int[] v1)
    {
        ListNode node = new ListNode();
        ListNode next = node;
        bool b = true;
        foreach (var v in v1)
        {
            if (b)
            {
                next.val = v;
                b = false;
            }
            else
            {
                next.next = new ListNode(v);
                next = next.next;
            }
        }
        if (b)
            return null;
        else
            return node;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode node = null;
        ListNode next = null;
        bool b = true;
        while (true) 
        {
            if (list1 == null)
            {
                if (list2 == null)
                {
                    return next;
                }
                if (b)
                {
                    node = list2;
                    b = false;
                }
                else
                    next.next = list2;
                break;
            }
            if (list2 == null)
            {
                if (b)
                {
                    node = list1;
                    b = false;
                }
                else
                    next.next = list1;
                break;
            }

            if (list1.val > list2.val)
            {
                if (b)
                {
                    node = next = list2;
                    b = false;
                }
                else
                {
                    next.next = list2;
                    next = next.next;
                }
                list2 = list2.next;
            }
            else 
            {
                if (b)
                {
                    node = next = list1;
                    b = false;
                }
                else
                {
                    next.next = list1;
                    next = next.next;
                }
                list1 = list1.next;
            }
        }
        return node;
    }

}