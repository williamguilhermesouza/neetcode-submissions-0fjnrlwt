public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        var p = new Dictionary<char, char> { {'(',')'}, {'{','}'}, {'[',']'}};

        foreach(var c in s)
        {
            if (p.TryGetValue(c, out char par)) st.Push(par);
            else
            {
                if (st.Count <= 0) return false;

                var val = st.Pop();
                if (c != val) return false;
            }
        }

        return st.Count == 0;
    }
}
