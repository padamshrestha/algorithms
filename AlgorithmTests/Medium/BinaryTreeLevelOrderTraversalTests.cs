using System.Collections.Generic;
using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class BinaryTreeLevelOrderTraversalTests
  {
    [Fact]
    public void LevelOrderTest()
    {
      TreeNode l0 = new TreeNode(3);
      l0.left = new TreeNode(9);
      l0.right = new TreeNode(20);
      l0.right.left = new TreeNode(15);
      l0.right.right = new TreeNode(7);

      var expectedLevels = new List<List<int>>();
      expectedLevels.Add(new List<int> { 3 });
      expectedLevels.Add(new List<int> { 9, 20 });
      expectedLevels.Add(new List<int> { 15, 7 });

      Assert.Equal(expectedLevels, BinaryTreeLevelOrderTraversal.LevelOrder(l0));
    }
  }
}
