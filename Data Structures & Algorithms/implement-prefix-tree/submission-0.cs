public class PrefixTree {
    public class TreeNode
    {
        public bool IsWord;
        public Dictionary<char, TreeNode> Children = new();
    }

    public TreeNode root;

    public PrefixTree() {
        root = new TreeNode();
    }
    
    public void Insert(string word) {
        TreeNode node = root;
        
        foreach(var c in word)
        {
            if (!node.Children.ContainsKey(c))
                node.Children[c] = new TreeNode();

            node = node.Children[c];
        }

        node.IsWord = true;
    }
    
    public bool Search(string word) {
        var node = Traverse(word);

        return node != null && node.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        var node = Traverse(prefix);

        return node != null;
    }

    public TreeNode Traverse(string prefix)
    {
        var node = root;

        foreach(var c in prefix)
        {
            if (!node.Children.TryGetValue(c, out node))
                return null;
        }

        return node;
    }
}
