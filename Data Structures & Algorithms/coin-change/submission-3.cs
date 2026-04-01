public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        Array.Sort(coins); // optimization to use top-down
        dp[0] = 0;

        int dfs(int val)
        {
            if (val < 0) return amount + 1;
            if (dp[val] <= amount) return dp[val];

            var min = amount + 1;
            foreach(var coin in coins)
            {
                if (coin > val) break; // optimization to use top-down
                min = Math.Min(min, dfs(val - coin) + 1);
            }
            
            dp[val] = min;
            return dp[val];
        }

        var res = dfs(amount);
        return res > amount ? -1 : res;
    }
}
