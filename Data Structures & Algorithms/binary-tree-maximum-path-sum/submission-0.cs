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
    public int max = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        if (root == null) return 0;

        Big(root);

        return max;
    }

    public int Big(TreeNode root)
    {
        if (root == null) return 0;

        var l = Math.Max(0, Big(root.left));
        var r = Math.Max(0, Big(root.right));

        max = Math.Max(max, root.val + l + r);

        return root.val + Math.Max(l, r);
    }
}
