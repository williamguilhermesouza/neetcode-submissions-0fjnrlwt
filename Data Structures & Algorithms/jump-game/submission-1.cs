public class Solution {
    public bool CanJump(int[] nums) {
        var res = new bool[nums.Length];

        res[^1] = true;

        for(var i = nums.Length - 2; i >= 0; --i)
        {
            for (var j = 1; j <= nums[i]; j++)
            {
                if (i + j >= nums.Length) break;
                if (res[i + j])
                {
                    res[i] = true;
                    break;
                }
            }
        }

        return res[0];
    }
}
