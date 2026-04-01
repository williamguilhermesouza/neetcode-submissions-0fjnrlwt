public class Solution {
    public bool Exist(char[][] board, string word) {
        var R = board.Length;
        var C = board[0].Length;
        var visited = new bool[R][];
        for (var i = 0; i < R; i++)
            visited[i] = new bool[C];

        var pos = new int[][] {[-1, 0], [1, 0], [0, -1], [0, 1]};


        bool dfs(int row, int col, int wi, bool[][] vis)
        {
            if (row < 0 || col < 0 || row == R || col == C 
                || board[row][col] != word[wi] || vis[row][col])
                return false;

            vis[row][col] = true;
            wi++;
            if (wi >= word.Length) return true;

            foreach(var p in pos)
            {
                if (dfs(row + p[0], col + p[1], wi, visited))
                    return true;
            }

            vis[row][col] = false;
            return false;
        }

        for(var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[0].Length; j++)
            {
                if (dfs(i, j, 0, visited))
                    return true;
            }                

        return false;
    }
}
