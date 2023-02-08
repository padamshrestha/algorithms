namespace Algorithms.Medium
{
  public class MergeTwoSortedLists
  {
    public ListNode Merge(ListNode l1, ListNode l2)
    {
      var sumHead = new ListNode(0);
      var currentNode = sumHead;

      while (l1 != null || l2 != null)
      {
        if (l1.val < l2.val)
        {
          currentNode.next = l1;
          l1 = l1.next;
        }
        else
        {
          currentNode.next = l2;
          l2 = l2.next;
        }

        currentNode = currentNode.next;
      }

      if (l1 != null) currentNode.next = l1;
      if (l2 != null) currentNode.next = l2;

      return sumHead.next;
    }
  }
}