using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class LinkedListCycleTests
  {
    [Fact]
    public void HasCycleTestTrue1()
    {
      var nodeList = new ListNode[4];
      var node1 = new ListNode(3);
      var node2 = new ListNode(2);
      var node3 = new ListNode(0);
      var node4 = new ListNode(-4);
      node1.next = node2;
      node2.next = node3;
      node3.next = node4;
      node4.next = node2;

      Assert.True(LinkedListCycle.HasCycle(node1));
    }

    [Fact]
    public void HasCycleTestTrue2()
    {
      var nodeList = new ListNode[2];
      var node1 = new ListNode(1);
      var node2 = new ListNode(2);
      node1.next = node2;
      node2.next = node1;

      Assert.True(LinkedListCycle.HasCycle(node1));
    }

    [Fact]
    public void HasCycleTestFalse()
    {
      var nodeList = new ListNode[1];
      var node1 = new ListNode(1);

      Assert.False(LinkedListCycle.HasCycle(node1));
    }
  }
}