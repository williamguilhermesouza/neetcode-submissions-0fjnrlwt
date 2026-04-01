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
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;

        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 1));

        var level = 0;

        while (stack.Any())
        {
            var (item, nl) = stack.Pop();
            if (item.left != null) stack.Push((item.left, nl + 1));
            if (item.right != null) stack.Push((item.right, nl + 1));

            level = Math.Max(level, nl);
        }

        return level;

    }
}
