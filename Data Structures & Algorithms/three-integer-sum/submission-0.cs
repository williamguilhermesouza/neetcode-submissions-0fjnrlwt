public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();

        List<List<int>> Sum(int b, int curr)
        {
            var res = new List<List<int>>();
            var l = b;
            var r = nums.Length - 1;

            while (l < r)
            {
                var sum = curr + nums[l] + nums[r];

                if (sum > 0) r--;
                else if (sum < 0) l++;
                else
                {
                    res.Add(new List<int>() {curr, nums[l], nums[r]});
                    var p = nums[l];
                    var n = nums[r];
                    while (nums[l] == p && l < r) l++;
                    while (nums[r] == n && l < r) r--;
                }                
            }

            return res;
        }


        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            if (i > 0 && val == nums[i - 1]) continue;

            var g = Sum(i + 1, val);

            result.AddRange(g);
        }

        return result;
    }
}
