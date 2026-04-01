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

public class Codec {
    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        var sb = new StringBuilder();
        Pre(root, sb);
        return sb.ToString();
    }

    public void Pre(TreeNode root, StringBuilder sb)
    {
        if (root == null)
        {
            sb.Append('n').Append(' ');
            return;
        }

        sb.Append(root.val).Append(' ');
        Pre(root.left, sb);
        Pre(root.right, sb);
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (string.IsNullOrEmpty(data)) return null;
        
        var s = data.Split();
        int i = 0;
        TreeNode Build()
        {
            if (s[i] == "n")
            {
                i++;
                return null;
            }
            
            var node = new TreeNode(int.Parse(s[i]));
            i++;
            node.left = Build();
            node.right = Build();

            return node;
        }

        var node = Build();
        return node;
    }
    

}
