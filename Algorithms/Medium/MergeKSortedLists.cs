namespace Algorithms.Medium
{
  public class MergeKSortedLists
  {
    public ListNode MergeKLists(ListNode[] lists)
    {
      ListNode smallestList = null;

      if (lists.Length == 1)
      {
        return lists[0];
      }

      for (var i = 0; i < (lists.Length - 1); i++)
      {
        if (i == 0)
        {
          smallestList = MergeTwoLists(lists[i], lists[i + 1]);
        }
        else
        {
          smallestList = MergeTwoLists(smallestList, lists[i + 1]);
        }
      }

      return smallestList;
    }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
      if (l1 == null)
      {
        return l2;
      }
      else if (l2 == null)
      {
        return l1;
      }
      else if (l1.val < l2.val)
      {
        l1.next = MergeTwoLists(l1.next, l2);
        return l1;
      }
      else
      {
        l2.next = MergeTwoLists(l1, l2.next);
        return l2;
      }
    }

  }
}
