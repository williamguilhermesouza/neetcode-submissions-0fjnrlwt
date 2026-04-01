public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if (n < 1) return true;

        var visited = new HashSet<int>();
        var ed = new Dictionary<int, List<int>>();

        foreach(var e in edges)
        {
            if (!ed.ContainsKey(e[0]))
                ed[e[0]] = new List<int>();

            ed[e[0]].Add(e[1]);

            if (!ed.ContainsKey(e[1]))
                ed[e[1]] = new List<int>();

            ed[e[1]].Add(e[0]); 
        }

        bool dfs(int node, int prev)
        {
            if (visited.Contains(node)) return false;

            visited.Add(node);

            ed.TryGetValue(node, out var list);

            if (list != null)
            {
                foreach(var l in list)
                {
                    if (l == prev) continue;

                    if (!dfs(l, node))
                        return false;
                }
            }

            return true;
        }

        return dfs(0, -1) && visited.Count == n;
    }
}
