public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if (intervals.Length == 1) return 0;

        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));

        var res = 0;
        int prevEnd = intervals[0][1];

        for (var i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] < prevEnd)
            {
                res++;
                prevEnd = Math.Min(intervals[i][1], prevEnd);
            }
            else
            {
                prevEnd = intervals[i][1];
            }
        }

        return res;
    }
}
