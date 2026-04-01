public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var l = new List<int>[n];

        foreach(var x in Enumerable.Range(0, n))
            l[x] = new List<int>();
        
        foreach(var pair in edges)
        {
            l[pair[0]].Add(pair[1]);

            l[pair[1]].Add(pair[0]);
        }

        var visited = new HashSet<int>();

        void dfs(int node, int prev)
        {
            if (visited.Contains(node)) return;

            visited.Add(node);
    
            foreach(var s in l[node])
            {
                if (s == prev) continue;

                dfs(s, node);
            }
        }

        var count = 0;
        foreach(var x in Enumerable.Range(0, n))
        {
            if (visited.Contains(x)) continue;
            count++;
            dfs(x, -1);
        }

        return count;
    }
}
