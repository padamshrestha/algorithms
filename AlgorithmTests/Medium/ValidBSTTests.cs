
using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class ValidBSTTests
  {
    [Fact]
    public void ValidBSTTest()
    {
      var node = new TreeNode(2);
      node.left = new TreeNode(1);
      node.right = new TreeNode(3);
      var validBST = new ValidBST();
      Assert.True(validBST.IsValid(node));
    }


    [Fact]
    public void InvalidBSTTest()
    {
      var node = new TreeNode(5);
      node.left = new TreeNode(1);
      node.right = new TreeNode(4);
      node.right.left = new TreeNode(3);
      node.right.right = new TreeNode(6);
      var validBST = new ValidBST();
      Assert.False(validBST.IsValid(node));
    }
  }
}