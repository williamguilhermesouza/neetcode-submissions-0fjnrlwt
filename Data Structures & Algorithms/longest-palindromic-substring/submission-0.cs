public class Solution {
    public string LongestPalindrome(string s) {
        var res = string.Empty;
        var resLen = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var l = i;
            var r = i;
            while(l >= 0 && r < s.Length && s[l] == s[r])
            {
                if ((r - l + 1) > resLen)
                {
                    res = s[l..(r+1)];
                    resLen = r - l + 1;
                }
                l--;
                r++;
            }

            l = i;
            r = i + 1;
            while(l >= 0 && r < s.Length && s[l] == s[r])
            {
                if ((r - l + 1) > resLen)
                {
                    res = s[l..(r+1)];
                    resLen = r - l + 1;
                }
                l--;
                r++;
            }
        }

        return res;
    }
}
