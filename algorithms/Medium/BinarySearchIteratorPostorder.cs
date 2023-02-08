// using System.Collections.Generic;

// namespace Algorithms.Medium
// {

//   public class BinarySearchIteratorPostorder
//   {
//     Stack<TreeNode> nodeStack = new Stack<TreeNode>();
//     public void BinarySearchIteratorPostorder(TreeNode root)
//     {
//       FindNextLeaf(root);
//     }


//     public TreeNode FindNextLeaf(TreeNode curr)
//     {
//       while (curr != null)
//       {
//         nodeStack.Push(curr);
//         if (curr.left != null)
//         {
//           curr = curr.left;
//         }
//         else
//         {
//           curr = curr.right;
//         }
//       }
//     }

//     public int Next()
//     {

//       var result = nodeStack.Pop();
//       if (nodeStack.Count > 0)
//       {
//         TreeNode top = nodeStack.Peek();
//         if (result == top.left)
//         {
//           FindNextLeaf(top.right);
//         }
//       }
//     }

//     public bool HasNext()
//     {
//       return nodeStack.Count > 0;
//     }

//     public List<int> postorderTraversal(TreeNode root)
//     {
//       BinarySearchIteratorPostorder iterator = new BinarySearchIteratorPostorder(root);
//       List<int> results = new List<int>();
//       while (iterator.hasNext())
//       {
//         results.Add(iterator.next());
//       }
//       return results;
//     }
//   }
// }
