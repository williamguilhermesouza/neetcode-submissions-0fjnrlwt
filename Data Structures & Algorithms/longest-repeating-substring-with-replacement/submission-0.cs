public class Solution {
    public int CharacterReplacement(string s, int k) {
        var l = 0;
        var res = 0;

        var count = new Dictionary<char, int>();

        for (var r = 0; r < s.Length; r++)
        {
            count[s[r]] = count.GetValueOrDefault(s[r], 0) + 1;

            while ((r - l + 1) - count.Values.Max() > k)
            {
                count[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
