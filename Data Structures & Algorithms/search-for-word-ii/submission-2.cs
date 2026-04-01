public class Solution {
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new();
        public string Word;

        public void AddWord(string word)
        {
            var cur = this;

            foreach (var c in word)
            {
                if (!cur.Children.TryGetValue(c, out var next))
                {
                    next = new TrieNode();
                    cur.Children[c] = next;
                }
                cur = next;
            }

            cur.Word = word;
        }
    }

    public List<string> FindWords(char[][] board, string[] words) {

        var root = new TrieNode();
        foreach (var w in words)
            root.AddWord(w);

        int R = board.Length;
        int C = board[0].Length;

        var res = new List<string>();

        void dfs(int r, int c, TrieNode node)
        {
            if (r < 0 || c < 0 || r >= R || c >= C)
                return;

            char ch = board[r][c];

            if (ch == '#' || !node.Children.TryGetValue(ch, out var next))
                return;

            if (next.Word != null)
            {
                res.Add(next.Word);
                next.Word = null; // avoid duplicates
            }

            board[r][c] = '#';

            dfs(r + 1, c, next);
            dfs(r - 1, c, next);
            dfs(r, c + 1, next);
            dfs(r, c - 1, next);

            board[r][c] = ch;
        }

        for (int i = 0; i < R; i++)
            for (int j = 0; j < C; j++)
                dfs(i, j, root);

        return res;
    }
}
