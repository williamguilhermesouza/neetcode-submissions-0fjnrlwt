public class Solution {
    public string foreignDictionary(string[] words) {

        var adj = new Dictionary<char, HashSet<char>>();
        foreach(var w in words)
        {
            foreach(var c in w)
            {
                adj[c] = new HashSet<char>();
            }
        }

        for(var i = 0; i < words.Length - 1; i++)
        {
            var w1 = words[i];
            var w2 = words[i + 1];
            var minLen = Math.Min(w1.Length, w2.Length);
            if (w1.Length > w2.Length && w1[..minLen] == w2[..minLen])
                return "";
            for (var j = 0; j < minLen; j++)
            {
                if (w1[j] != w2[j])
                {
                    adj[w1[j]].Add(w2[j]);
                    break;
                }
            }
        }

        var res = new StringBuilder();
        var visit = new Dictionary<char, bool>();
        
        bool dfs(char c)
        {
            if (visit.ContainsKey(c))
                return visit[c];
            
            visit[c] = true;
            foreach(var nei in adj[c])
            {
                if (dfs(nei))
                    return true;
            }

            visit[c] = false;
            res.Append(c);
            return false;
        }

        foreach(var c in adj.Keys)
        {
            if (dfs(c))
                return "";
        }

        var asC = res.ToString().ToCharArray();
        Array.Reverse(asC);
        var re = new string(asC);
        return re;
    }
}
