public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var pre = new Dictionary<int, List<int>>();

        foreach(var pair in prerequisites)
        {
            if (!pre.ContainsKey(pair[0]))
                pre.Add(pair[0], new List<int>());
            pre[pair[0]].Add(pair[1]);
        }

        var visitSet = new HashSet<int>();
        bool dfs(int crs)
        {
            if (visitSet.Contains(crs)) return false;
            if (!pre.TryGetValue(crs, out var list) || list.Count == 0) return true;
            
            visitSet.Add(crs);
            foreach(var p in pre[crs])
            {
                if (!dfs(p))
                    return false;
            }

            visitSet.Remove(crs);
            pre[crs] = new List<int>();
            return true;
        }

        for (var i = 0; i < numCourses; i++)
        {
            if (!dfs(i))
                return false;
        }

        return true;
    }
}
