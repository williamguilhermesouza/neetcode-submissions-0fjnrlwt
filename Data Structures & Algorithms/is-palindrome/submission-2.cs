public class Solution {
    public bool IsPalindrome(string s) {
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            while(!Char.IsLetterOrDigit(s[l]) && l < s.Length - 1) l++;
            while(!Char.IsLetterOrDigit(s[r]) && r > 0) r--;

            if (l >= r) return true;

            if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                return false;

            l++;
            r--;
        }

        return true;
    }
}
