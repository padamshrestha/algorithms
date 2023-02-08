using System;

namespace Algorithms.Simple
{

  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
      val = x;
    }
  }

  public class LinkedListCycle
  {
    public static bool HasCycle(ListNode head)
    {
      if (head == null || head.next == null) return false;

      ListNode slow = head;
      ListNode fast = head.next;

      while (slow != fast)
      {
        if (head == null || head.next == null) return false;

        slow = slow.next;
        fast = fast.next.next;
      }

      return true;
    }
  }
}
