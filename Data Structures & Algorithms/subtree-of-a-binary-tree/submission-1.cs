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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null && subRoot == null) return true;
        if (root == null || subRoot == null) return false;

        if (root.val == subRoot.val && Equ(root, subRoot)) return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool Equ(TreeNode r1, TreeNode r2)
    {
        if (r1 == null && r2 == null) return true;
        if (r1 == null || r2 == null) return false;

        if (r1.val != r2.val) return false;

        return Equ(r1.left, r2.left) && Equ(r1.right, r2.right);
    }
}
