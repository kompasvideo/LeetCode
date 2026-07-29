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
        int a = 4;
        var sol = new Solution();
        var result = sol.DeleteDuplicates(a);
        Console.WriteLine(result);
    }

    public ListNode DeleteDuplicates(ListNode head)
    {

        return head;
    }
}