public class Solution {
    public int FindMin(int[] nums) {
        var l = 0;
        var r = nums.Length - 1;
        
        while (l < r)
        {
            var lV = nums[l];
            var rV = nums[r];

            var m = (r - l) / 2 + l;
            var mV = nums[m];

            if (mV > rV) l = m + 1;
            else r = m;
        }

        return nums[l];
    }
}
