public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r)
        {
            var m = (r - l) / 2 + l;

            if (nums[m] == target) return m;

            if (nums[l] <= nums[m])
                if (nums[l] <= target && target < nums[m]) r = m;
                else l = m + 1;
            else
                if (nums[m] < target && target <= nums[r]) l = m + 1;
                else r = m;
        }

        return -1;
    }
}
