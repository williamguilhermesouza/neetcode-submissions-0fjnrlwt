public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            while(!IsAlpha(s[l]) && l < s.Length - 1) l++;
            while(!IsAlpha(s[r]) && r > 0) r--;

            if (l >= r) return true;

            if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                return false;

            l++;
            r--;
        }

        return true;
    }

    public bool IsAlpha(char c)
    {
        var a = (int) 'a';
        var z = (int) 'z';

        var A = (int) 'A';
        var Z = (int) 'Z';

        var n0 = (int) '0';
        var n9 = (int) '9';

        var n = (int) c;
        if ((c >= a && c <= z) || (c >= A && c <= Z) || (c >= n0 && c <= n9)) return true;

        return false;
    }
}
