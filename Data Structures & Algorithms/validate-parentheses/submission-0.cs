public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();

        foreach(var c in s)
        {
            if (c == '[') st.Push(']');
            else if (c == '{') st.Push('}');
            else if (c == '(') st.Push(')');
            else
            {
                if (st.Count <= 0) return false;

                var val = st.Pop();
                if (c != val) return false;
            }
        }

        if (st.Count != 0) return false;

        return true;
    }
}
