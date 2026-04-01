public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var curr = new Dictionary<char, int>();

        var l = 0;
        var r = 0;
        var max = 0;

        while(r < s.Length)
        {
            if (curr.TryGetValue(s[r], out var pos) && pos >= l)
                l = pos + 1;
            
            curr[s[r]] = r;
            max = Math.Max(max, r - l + 1);
            r++;
        }

        return max;
    }
}
