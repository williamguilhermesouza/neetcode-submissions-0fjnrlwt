public class Solution {
    public int NumIslands(char[][] grid) {
        
        var R = grid.Length;
        var C = grid[0].Length;

        var vis = new bool[R][];
        for(var i = 0; i < R; i++)
            vis[i] = new bool[C];
        
        var dir = new int[][] { [1, 0], [-1, 0], [0, 1], [0, -1]};

        var res = 0;

        void Count(int row, int col)
        {
            if (row < 0 || col < 0 || row >= R || col >= C 
                || grid[row][col] != '1' || vis[row][col])
                return;
            
            vis[row][col] = true;

            Count(row - 1, col);
            Count(row + 1, col);
            Count(row, col - 1);
            Count(row, col + 1);
        }

        for (var i = 0; i < R; i++)
            for (var j = 0; j < C; j++)
            {
                if (grid[i][j] == '1' && !vis[i][j])
                {
                    res++;
                    var q = new Queue<(int, int)>();
                    q.Enqueue((i, j));
                    while(q.Count > 0)
                    {
                        var (r, c) = q.Dequeue();
                        
                        foreach (var d in dir)
                        {
                            var nr = r + d[0];
                            var nc = c + d[1];
                            if (nr >= 0 && nc >= 0
                                && nr < R && nc < C
                                && grid[nr][nc] == '1' && !vis[nr][nc])
                                {
                                    q.Enqueue((nr, nc));
                                    vis[nr][nc] = true;
                                }
                        }
                    }
                    //Count(i, j);
                }
            }
            
        return res;
    }
}
