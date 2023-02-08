using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class MaximumLevelSumBinaryTreeTests
  {
    [Fact]
    public void MaxLevelSumTest1()
    {
      TreeNode l0 = new TreeNode(1);
      l0.left = new TreeNode(7);
      l0.right = new TreeNode(0);
      l0.left.left = new TreeNode(7);
      l0.left.right = new TreeNode(-8);

      Assert.Equal(2, MaximumLevelSumBinaryTree.MaxLevelSum(l0));
    }

    [Fact]
    public void MaxLevelSumTest2()
    {
      TreeNode l0 = new TreeNode(989);
      l0.right = new TreeNode(10250);
      l0.right.left = new TreeNode(98693);
      l0.right.right = new TreeNode(-89388);
      l0.right.right.right = new TreeNode(-32127);

      Assert.Equal(2, MaximumLevelSumBinaryTree.MaxLevelSum(l0));
    }
  }
}
