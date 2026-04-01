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
    public TreeNode InvertTree(TreeNode root) {
        void Inverter(TreeNode node)
        {
            if (node == null) return;

            var t = node.left;
            node.left = node.right;
            node.right = t;
        }

        void go(TreeNode node)
        {
            if (node == null) return;

            go(node.left);
            go(node.right);

            Inverter(node);
        }

        go (root);
        return root;
    }
}
