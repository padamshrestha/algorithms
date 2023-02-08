using System;
using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class ReverseLinkedList
  {
    public static ListNode Reverse(ListNode root)
    {
      ListNode prev = null;
      ListNode current = root;

      while (current != null)
      {
        var tempNext = current.next;
        current.next = prev;
        prev = current;
        current = tempNext;
      }

      return prev;
    }
  }
}
