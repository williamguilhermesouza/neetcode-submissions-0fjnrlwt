public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) return nums[0];

        var rob1 = Robin(nums[..^1]);
        var rob2 = Robin(nums[1..]);

        return Math.Max(rob1, rob2);
    }

    int Robin(int[] nums)
    {
        var rob1 = 0;
        var rob2 = 0;

        for(var i = 0; i < nums.Length; i ++)
        {
            var n = nums[i];
            var temp = Math.Max(rob1 + n, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;
    }
}
