namespace Algorithms.Medium
{
  public class MergeKSortedListsUsingHeap
  {
    /// <summary>
    /// https://leetcode.com/problems/merge-k-sorted-lists/discuss/10630/C-Using-MinHeap-(PriorityQueue)-Implemented-Using-SortedDictionary
    /// </summary>
    /// <param name="lists"></param>
    /// <returns></returns>
    public static ListNode MergeKLists(ListNode[] lists)
    {
      var heap = new MinHeap();

      /// put all nodes into minimum heap first one time
      foreach (var node in lists)
      {
        if (node == null)
        {
          continue;
        }

        heap.Add(node.val, node);
      }

      ///and then build a linked list using the ascending order
      ListNode curr = null, newHead = null;

      while (heap.map.Count > 0)
      {
        var node = heap.PopMin();

        if (node.next != null)
        {
          heap.Add(node.next.val, node.next);
        }

        if (curr == null)
        {
          curr = node;
          newHead = curr;
        }
        else
        {
          curr.next = node;
          curr = curr.next;
        }
      }

      return newHead;
    }
  }
}
