public class Solution {
    public int Rob(int[] nums) {
        var rob1 = 0;
        var rob2 = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var n = nums[i];
            var temp = Math.Max(n + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }

        return rob2;
    }
}
