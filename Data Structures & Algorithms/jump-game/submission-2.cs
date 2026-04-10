public class Solution {
    public bool CanJump(int[] nums) {
        var g = nums.Length - 1;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= g)
                g = i;
        }

        return g == 0;
    }
}
