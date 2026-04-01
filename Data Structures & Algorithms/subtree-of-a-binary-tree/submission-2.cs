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
        if (subRoot == null) return true;
        if (root == null) return false;

        if (SameTree(root, subRoot)) 
            return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool SameTree(TreeNode r1, TreeNode r2)
    {
        if (r1 == null || r2 == null) 
            return r1 == r2;

        if (r1.val != r2.val) 
            return false;

        return SameTree(r1.left, r2.left) && SameTree(r1.right, r2.right);
    }
}
