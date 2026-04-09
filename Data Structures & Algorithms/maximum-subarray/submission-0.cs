public class Solution {
    public int MaxSubArray(int[] nums) {
        long res = int.MinValue;
        long sum = int.MinValue;

        for(var i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            sum = Math.Max(val, sum + val);
            res = Math.Max(res, sum);

        }

        return (int) res;
    }
}
