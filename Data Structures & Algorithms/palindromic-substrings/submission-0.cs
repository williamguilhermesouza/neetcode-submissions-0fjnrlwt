public class Solution {
    public int CountSubstrings(string s) {
        var res = 0;

        for(var i = 0; i < s.Length; i++)
        {
            res += Expand(s, i, i);
            res += Expand(s, i, i + 1);
        }

        return res;
    }

    public int Expand(string s, int b, int e)
    {
        var res = 0;

        while(b >= 0 && e < s.Length && s[b] == s[e])
        {
            res++;
            b--;
            e++;
        }

        return res;
    }
}
