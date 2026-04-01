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

        var s = new Stack<TreeNode>();
        var cur = root;
        while (cur != null || s.Count > 0)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }

            cur = s.Pop();
            if (--k == 0) return cur.val;

            cur = cur.right;
        }

        return -1;
    }
}
