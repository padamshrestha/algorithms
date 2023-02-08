using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class AddTwoNumbersTests
  {
    [Fact]
    public void TestName()
    {
      var l1 = new ListNode(2);
      l1.next = new ListNode(4);
      l1.next.next = new ListNode(3);

      var l2 = new ListNode(5);
      l2.next = new ListNode(6);
      l2.next.next = new ListNode(4);

      var l3 = new ListNode(7);
      l3.next = new ListNode(0);
      l3.next.next = new ListNode(8);

      Assert.Equal(l3, AddTwoNumbers.Add(l1, l2));
    }
  }
}
