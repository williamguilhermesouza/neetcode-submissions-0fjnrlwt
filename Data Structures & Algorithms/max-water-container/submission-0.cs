public class Solution {
    public int MaxArea(int[] heights) {
        var l = 0;
        var r = heights.Length - 1;

        var m = 0;

        while (l < r)
        {
            var cH = Math.Min(heights[l], heights[r]);
            var cW = r - l;
            m = Math.Max(m, cH * cW);

            if (heights[l] <= heights[r]) l++;
            else r--;
        }

        return m;   
    }
}
