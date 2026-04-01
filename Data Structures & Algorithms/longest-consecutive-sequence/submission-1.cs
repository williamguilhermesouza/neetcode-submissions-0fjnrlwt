public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        var s = nums.ToHashSet();
        var m = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            if (s.Contains(val - 1)) continue;

            var c = 1;
            while (s.Contains(val + c))
                c++;
                
            m = Math.Max(c, m);
        }

        return m;
    }
}
