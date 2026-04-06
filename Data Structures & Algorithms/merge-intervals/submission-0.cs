public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 1) return intervals;

        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));

        var res = new List<int[]>();
        res.Add(intervals[0]);

        for (var i = 1; i < intervals.Length; i++)
        {
            var s = intervals[i][0];
            var e = intervals[i][1];

            var lastEnd = res[^1][1];

            if (s <= lastEnd)
                res[^1][1] = Math.Max(lastEnd, e);
            else
                res.Add([s,e]);
        }

        return res.ToArray();
    }
}
