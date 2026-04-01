public class Solution {
    public int MaxProduct(int[] nums) {
        var res = nums.Max();
        var curMin = 1;
        var curMax = 1;

        for(var i = 0; i < nums.Length; i++)
        {
            var n = nums[i];

            if (n == 0) 
            {
                curMin = 1;
                curMax = 1;
                continue;
            }

            var tmp = curMax * n;
            curMax = Math.Max(Math.Max(tmp, n), n * curMin);
            curMin = Math.Min(Math.Min(tmp, n), n * curMin);
            res = Math.Max(res, curMax);
        }

        return res;
    }
}
