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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (p == null || q == null || root == null) return root;

        if ((p.val <= root.val && root.val <= q.val) 
            || (q.val <= root.val && root.val <= p.val)) return root;

        if (p.val < root.val && q.val < root.val) return LowestCommonAncestor(root.left, p, q);

        return LowestCommonAncestor(root.right, p, q);
    }
}
