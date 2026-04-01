public class Solution {
    public class Node
    {
        public int val;
        public List<Node> req = new List<Node> ();

        public Node(int _val)
        {
            val = _val;
        }
    }
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var nodes = new Dictionary<int, Node>();

        foreach(var pair in prerequisites)
        {
            Node n;
            if (!nodes.TryGetValue(pair[0], out n))
            {
                n = new Node(pair[0]);
                nodes.Add(pair[0], n);
            }
            Node r;
            if (!nodes.TryGetValue(pair[1], out r))
            {
                r = new Node(pair[1]);
                nodes.Add(pair[1], r);
            }

            n.req.Add(r);
        }

        var state = new int[numCourses];
        bool hasCycle(Node node)
        {
            if (state[node.val] == 1) return true;
            if (state[node.val] == 2) return false;
            if (node.req.Count < 1) return false;

            state[node.val] = 1;

            foreach(var n in node.req)
            {
                if (hasCycle(n))
                    return true;
            }

            state[node.val] = 2;
            return false;
        }

        foreach(var t in nodes)
            if (hasCycle(t.Value))
                return false;

        return true;
    }
}
