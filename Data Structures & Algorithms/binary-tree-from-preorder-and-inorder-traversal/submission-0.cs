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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder == null || preorder.Length == 0 
            || inorder == null || inorder.Length == 0) return null;

        var node = new TreeNode(preorder[0]);

        var ind = Array.IndexOf(inorder, preorder[0]);
        node.left = BuildTree(preorder[1..(1+ind)], inorder[..ind]);
        node.right = BuildTree(preorder[(1+ind)..], inorder[(1+ind)..]);

        return node;
    }
}
