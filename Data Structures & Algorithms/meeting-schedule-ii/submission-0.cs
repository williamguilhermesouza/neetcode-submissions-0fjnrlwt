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
    public int MinMeetingRooms(List<Interval> intervals) {
        var start = new List<int>();
        var end = new List<int>();

        foreach(var i in intervals)
        {
            start.Add(i.start);
            end.Add(i.end);
        }

        start.Sort();
        end.Sort();

        var res = 0;
        var count = 0;

        var s = 0;
        var e = 0;

        while (s < intervals.Count)
        {
            if (start[s] < end[e])
            {
                s++;
                count++;
            }
            else
            {
                e++;
                count--;
            }

            res = Math.Max(res, count);
        }

        return res;
    }
}
