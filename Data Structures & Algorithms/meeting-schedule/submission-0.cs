/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        intervals.Sort((x, y) => x.start.CompareTo(y.start));

        for(var i = 1; i < intervals.Count; i++)
        {
            var i1 = intervals[i - 1];
            var i2 = intervals[i];

            if (i1.end > i2.start)
                return false;

        }
        return true;
    }
}
