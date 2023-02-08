using System;
using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class ReverseLinkedListTests
  {
    [Fact]
    public void ValidTest1()
    {
      var nodeList = new ListNode[5];
      var node1 = new ListNode(2);
      var node2 = new ListNode(3);
      var node3 = new ListNode(4);
      var node4 = new ListNode(5);
      var node5 = new ListNode(5);

      node1.next = node2;
      node2.next = node3;
      node3.next = node4;
      node4.next = node5;

      Assert.Equal(ReverseLinkedList.Reverse(node1), node5);
    }

    [Fact]
    public void ValidTest2()
    {
      var nodeList = new ListNode[2];
      var node1 = new ListNode(1);
      var node2 = new ListNode(2);

      node1.next = node2;

      Assert.Equal(ReverseLinkedList.Reverse(node1), node2);
    }
  }
}