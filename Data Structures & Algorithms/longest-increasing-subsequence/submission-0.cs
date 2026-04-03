public class Solution {
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length];
        Array.Fill(dp, 1);
        var max = 0;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
            }

            max = Math.Max(max, dp[i]);
        }

        return max;
    }
}
