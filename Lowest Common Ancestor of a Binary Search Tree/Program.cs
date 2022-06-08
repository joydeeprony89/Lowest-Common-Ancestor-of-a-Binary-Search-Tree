using System;

namespace Lowest_Common_Ancestor_of_a_Binary_Search_Tree
{
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(6);
      root.left = new TreeNode(2);
      root.right = new TreeNode(8);
      root.left.left = new TreeNode(0);
      root.left.right = new TreeNode(4);
      root.left.right.left = new TreeNode(3);
      root.left.right.right = new TreeNode(5);
      root.right.left = new TreeNode(7);
      root.right.right = new TreeNode(9);
      Solution s = new Solution();
      s.LowestCommonAncestor(root, new TreeNode(3), new TreeNode(5));
    }
  }

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; left = right = null; }
  }

  public class Solution
  {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
      while (root != null)
      {
        if (p.val > root.val && q.val > root.val) root = root.right;
        else if (p.val < root.val && q.val < root.val) root = root.left;
        else break;
      }

      return root;
    }
  }
}
