public class Solution {
    public int NumIslands(char[][] grid) {
        
        var R = grid.Length;
        var C = grid[0].Length;

        var vis = new bool[R][];
        for(var i = 0; i < R; i++)
            vis[i] = new bool[C];

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
                    Count(i, j);
                }
            }
            
        return res;
    }
}
