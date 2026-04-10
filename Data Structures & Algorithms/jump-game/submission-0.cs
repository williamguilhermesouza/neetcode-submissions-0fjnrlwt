public class Solution {
    public bool CanJump(int[] nums) {
        var target = nums.Length - 1;

        bool dfs(int ind)
        {
            if (ind == target) return true;
            if (nums[ind] == 0) return false;
            if (ind >= nums.Length) return false;


            for(var i = 1; i <= nums[ind]; i++)
            {
                if (dfs(ind + i)) return true;
            }

            return false;
        }

        return dfs(0);

    }
}
