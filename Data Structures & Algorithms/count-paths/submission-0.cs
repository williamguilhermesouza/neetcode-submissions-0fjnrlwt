public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[m][];
        for(var i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            dp[i][n-1] = 1;
        }

        Array.Fill(dp[m-1], 1);

        for (var i = m - 2; i >= 0; i--)
        {
            for (var j = n - 2; j >= 0; j--)
            {
                dp[i][j] = dp[i+1][j] + dp[i][j + 1];
            }
        }

        return dp[0][0];
    }
}
