namespace Algorithms.Medium
{
  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
  }
  public static class AddTwoNumbers
  {
    public static ListNode Add(ListNode l1, ListNode l2)
    {
      ListNode tail = new ListNode(0);
      ListNode temp = tail;
      int sum = 0;

      while (l1 != null || l2 != null || sum > 0)
      {
        sum += (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
        tail.next = new ListNode(sum % 10);
        tail = tail.next;

        if (l1 != null) l1 = l1.next;
        if (l2 != null) l2 = l2.next;
        sum /= 10;
      }

      return temp.next;
    }
  }
}
