public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        var R = heights.Length;
        var C = heights[0].Length;

        var pac = new HashSet<(int, int)>();
        var atl = new HashSet<(int, int)>();
        
        void dfs(int r, int c, HashSet<(int, int)> visit, int prevHeight)
        {
            if (r < 0 || c < 0 || r == R || c == C
                || visit.Contains((r,c)) || heights[r][c] < prevHeight) return;

            visit.Add((r,c));
            dfs(r + 1, c, visit, heights[r][c]);
            dfs(r - 1, c, visit, heights[r][c]);
            dfs(r, c + 1, visit, heights[r][c]);
            dfs(r, c - 1, visit, heights[r][c]);
        }

        for (var i = 0; i < C; i++)
        {
            dfs(0, i, pac, heights[0][i]);
            dfs(R - 1, i, atl, heights[R - 1][i]);
        }

        for (var r = 0; r < R; r++)
        {
            dfs(r, 0, pac, heights[r][0]);
            dfs(r, C - 1, atl, heights[r][C - 1]);
        }

        var res = new List<List<int>>();
        for (var i = 0; i < R; i++)
        {
            for (var j = 0; j < C; j++)
            {
                if (pac.Contains((i,j)) && atl.Contains((i,j)))
                    res.Add(new List<int> {i, j});
            }
        }

        return res;
    }
}
