namespace Algorithms.Medium
{

  /* // Definition for singly-linked list.
  public class ListNode
  {
    int val;
    ListNode next; ListNode(int x) { val = x; }
  } */

  public class SwapPairs
  {
    public ListNode Swap(ListNode head)
    {
      if (head == null || head.next == null) return head;

      var tempNode = new ListNode(-1);
      tempNode.next = head;
      head = tempNode;

      while (head != null && head.next != null && head.next.next != null)
      {
        var n1 = head.next;
        var n2 = n1.next;

        n1.next = n2.next;
        n2.next = n1;

        head.next = n2;
        head = n1;
      }

      return tempNode.next;
    }
  }
}
