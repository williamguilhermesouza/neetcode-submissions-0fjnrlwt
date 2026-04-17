public class Solution {
    public int MissingNumber(int[] nums) {
        var res = 0;
        var n = nums.Length;

        for(var i = 0; i < n; i++)
        {
            res ^= i;
            res ^= nums[i];
        }

        res ^= n;

        return res;

    }
}
