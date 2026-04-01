public class Solution {
    public string MinWindow(string s, string t) {
        var count = new Dictionary<char, int>();
        var seen = new Dictionary<char, int>();
        var min = int.MaxValue;
        var minB = -1;

        var l = 0;
        foreach(var c in t)
            count[c] = count.GetValueOrDefault(c, 0) + 1;

        var uFreq = count.Count;
        var seenFreq = 0;        
        for(var r = 0; r < s.Length; r++)
        {
            var c = s[r];
            seen[c] = seen.GetValueOrDefault(c, 0) + 1;

            if (count.TryGetValue(c, out var f) && f == seen[c])
                seenFreq++;
            
            while (seenFreq == uFreq && l <= r)
            {
                var winL = r - l + 1;
                if (winL < min)
                {
                    min = Math.Min(min, r - l + 1);
                    minB = l;
                }
                
                var prev = s[l];
                seen[prev] = Math.Max(0, seen[prev] - 1);
                
                if (count.ContainsKey(prev) && seen[prev] < count[prev])
                    seenFreq--;
                    
                l++;
            }
        }

        return minB == -1 ? string.Empty : s.Substring(minB, min);
    }
}
