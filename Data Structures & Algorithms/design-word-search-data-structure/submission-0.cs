public class WordDictionary {
    public class Node
    {
        public Dictionary<char, Node> Children = new();
        public bool IsWord;
    }

    public Node root = new ();

    public WordDictionary() {}
    
    public void AddWord(string word) {
        var cur = root;

        foreach(var c in word)
        {
            if (!cur.Children.ContainsKey(c))
                cur.Children[c] = new Node();
            
            cur = cur.Children[c];
        }

        cur.IsWord = true;
    }
    
    public bool Search(string word) {
        return DFS(word, 0, root);
    }

    public bool DFS(string word, int i, Node node)
    {
        if (i == word.Length) return node.IsWord;
        var c = word[i];

        if (c == '.')
        {
            foreach(var n in node.Children.Values)
                if (DFS(word, i + 1, n))
                    return true;

            return false;
        }

        if (!node.Children.TryGetValue(c, out var next))
            return false;
        
        return DFS(word, i+1, next);
    }
}
