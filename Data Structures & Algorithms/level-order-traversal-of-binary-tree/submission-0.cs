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
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root == null) return new();
        
        var q = new Queue<TreeNode>();
        var r = new List<List<int>>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            var toAdd = new List<int>();
            var levelSize = q.Count;
            for(var i = 0; i <levelSize; i++)
            {
                var item = q.Dequeue();
                toAdd.Add(item.val);

                if (item.left != null) q.Enqueue(item.left);
                if (item.right != null) q.Enqueue(item.right);
            }

            r.Add(toAdd);
        }

        return r;
    }
}
