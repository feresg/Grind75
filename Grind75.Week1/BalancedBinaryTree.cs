#nullable disable
using Grind75.Common;

namespace Week1;

public class BalancedBinaryTree
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        var treeHeight = Math.Abs(GetTreeHeight(root.left) - GetTreeHeight(root.right));
        if (treeHeight > 1) return false;

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    private static int GetTreeHeight(TreeNode node)
    {
        if (node == null) return 0;
        return Math.Max(GetTreeHeight(node.left), GetTreeHeight(node.right)) + 1;
    }
}