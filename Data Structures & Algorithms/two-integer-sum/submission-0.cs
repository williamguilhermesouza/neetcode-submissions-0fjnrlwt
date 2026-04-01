public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var m = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i ++)
        {
            if (m.TryGetValue(target - nums[i], out int i2))
                return [i2, i];
            
            m[nums[i]] = i;
        }

        return [];
    }
}
