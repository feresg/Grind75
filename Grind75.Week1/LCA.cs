#nullable disable
using Grind75.Common;

namespace Week1;

public static class LCA
{
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root.val > p.val && root.val > q.val) return LowestCommonAncestor(root.left, p, q);
        if (root.val < p.val && root.val < q.val) return LowestCommonAncestor(root.right, p, q);
        return root;
    }
}