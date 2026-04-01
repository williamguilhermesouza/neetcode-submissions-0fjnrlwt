public class Solution {
    public int MaxProfit(int[] prices) {
        var min = 0;
        var result = 0;

        for (var i = 0; i < prices.Length; i++)
        {
            if (prices[i] < prices[min])
            {
                min = i;
                continue;
            }

            var p = prices[i] - prices[min];
            result = Math.Max(result, p);
        }

        return result;
    }
}
