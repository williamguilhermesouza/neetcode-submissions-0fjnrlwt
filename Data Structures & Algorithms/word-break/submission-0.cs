public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        var dp = new bool[s.Length + 1];
        dp[s.Length] = true;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            foreach(var w in wordDict)
            {
                if (i + w.Length <= s.Length && s[i..(i + w.Length)] == w)
                    dp[i] = dp[i + w.Length];
                if (dp[i])
                    break; 
            }
        }

        return dp[0];
    }
}
