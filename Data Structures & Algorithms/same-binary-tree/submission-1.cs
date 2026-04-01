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
    public bool IsSameTree(TreeNode p, TreeNode q) {

        var stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((p,q));

        while (stack.Any())
        {
            var (p1, q1) = stack.Pop();
            if (p1 == null || q1 == null)
            {
                if (p1 != q1) return false;
                continue;
            }
            
            if (p1.val != q1.val) return false;

            stack.Push((p1.left, q1.left));
            stack.Push((p1.right, q1.right));
        }

        return true;
    }
}
