public class Solution {
    public int MissingNumber(int[] nums) {
        
        var n = nums.Length;
        var map = new bool[n+1];

        for(var i = 0; i < n; i++)
        {
            map[nums[i]] = true;
        }

        for(var i = 0; i < map.Length; i++)
        {
            if (!map[i])
                return i;
        }
        return n;
    }
}
