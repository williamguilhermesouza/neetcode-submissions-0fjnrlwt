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

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var level = 0;

        while (queue.Any())
        {
            var levelSize = queue.Count;

            for (var i = 0; i < levelSize; i++)
            {
                var item = queue.Dequeue();
                if (item.left != null) queue.Enqueue(item.left);
                if (item.right != null) queue.Enqueue(item.right);
            }

            level++;
        }

        return level;

    }
}
