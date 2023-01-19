#nullable disable
using Grind75.Common;

namespace Week1;

public static class InvertBinaryTree
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;
        return new TreeNode(root.val, InvertTree(root.right), InvertTree(root.left));
    }
}