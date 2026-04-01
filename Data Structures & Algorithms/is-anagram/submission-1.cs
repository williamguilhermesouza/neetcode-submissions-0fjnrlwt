public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;
        
        var sortedS = s.ToArray();
        var sortedT = t.ToArray();

        Array.Sort(sortedS);
        Array.Sort(sortedT);

        for (var i = 0; i < sortedS.Length; i++)
        {
            if (sortedS[i] != sortedT[i])
                return false;
        }

        return true;
    }
}
