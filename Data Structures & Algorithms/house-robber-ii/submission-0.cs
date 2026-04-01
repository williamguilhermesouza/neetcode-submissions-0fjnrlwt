public class Solution {
    public int Rob(int[] nums) {
        var s = nums.Length;

        if (s == 1) return nums[0];

        var rob1 = 0;
        var rob2 = 0;

        for(var i = 0; i < s - 1; i ++)
        {
            var n = nums[i];
            var temp = Math.Max(rob1 + n, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        var rob3 = 0;
        var rob4 = 0;
        for(var i = 1; i < s; i ++)
        {
            var n = nums[i];
            var temp = Math.Max(rob3 + n, rob4);
            rob3 = rob4;
            rob4 = temp;
        }

        return Math.Max(rob2, rob4);

    }
}
