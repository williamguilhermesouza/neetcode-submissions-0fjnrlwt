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
    public bool IsValidBST(TreeNode root) {
        return Valid(root, int.MinValue, int.MaxValue);
    }

    public bool Valid(TreeNode root, int min, int max)
    {
        if (root == null) return true;
        if (root.val >= max || root.val <= min) return false;

        return Valid(root.left, min, root.val) &&
            Valid(root.right, root.val, max);
    }
}
