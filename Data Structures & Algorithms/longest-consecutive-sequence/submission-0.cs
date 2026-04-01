public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;

        Array.Sort(nums);

        var m = 0;
        var s = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i-1] == nums[i]) continue;

            if (nums[i-1] + 1 == nums[i])
                s++;
            else
            {
                m = Math.Max(m, s);
                s = 1;
            }
        }

        m = Math.Max(m, s);
        return m;
    }
}
