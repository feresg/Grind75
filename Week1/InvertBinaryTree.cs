#nullable disable
namespace Week1;

public static class InvertBinaryTree
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;
        return new TreeNode(root.val, InvertTree(root.right), InvertTree(root.left));
    }
}

public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
     {
             this.val = val;
             this.left = left;
             this.right = right;
     }
}
