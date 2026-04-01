/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        var copies = new Dictionary<Node, Node>();

        Node dfs(Node root)
        {
            if (root == null) return null;
            if (copies.TryGetValue(root, out var nn))
                return nn;
            
            var nNode = new Node(root.val);
            copies.Add(root, nNode);

            foreach(var n in root.neighbors)
                nNode.neighbors.Add(dfs(n));

            return nNode;
        }

        return dfs(node) ?? null;
    }
}
