public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];

        var prod = 1;
        for(var i = 0; i < nums.Length; i++)
        {
            result[i] = prod;
            prod *= nums[i];
        }

        prod = 1;
        for (var j = nums.Length - 1; j >= 0; --j)
        {
            result[j] *= prod;
            prod *= nums[j];
        }

        return result;
    }
}