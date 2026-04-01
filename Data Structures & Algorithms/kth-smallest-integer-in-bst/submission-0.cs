/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        if (root == null) return -1;

        return Pre(root,ref k) ?? -1;
    }

    public int? Pre(TreeNode root, ref int k)
    {
        if (root == null) return null;

        var l = Pre(root.left,ref k);
        if (l != null) return l;
        k--;
        if (k == 0) return root.val;
        var r = Pre(root.right,ref k);
        if (r != null) return r;
        
        return null;
    }
}
