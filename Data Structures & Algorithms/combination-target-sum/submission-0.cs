public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        var cur = new List<int>();

        void Find(int start, int sum)
        {
            if (sum == target) 
            {
                result.Add(new List<int>(cur));
                return;
            }

            if (sum > target)
                return;

            for (var i = start; i < nums.Length; i++)
            {
                cur.Add(nums[i]);
                Find(i, sum + nums[i]);
                cur.Remove(nums[i]);
            }
        }

        Find(0, 0);

        return result;
    }
}
