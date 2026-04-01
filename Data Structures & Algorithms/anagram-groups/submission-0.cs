public class Solution {
    // must be sorted
    public static bool IsAnagram(char[] s1, char[] s2)
    {
        if (s1.Length != s2.Length) return false;

        for (var i = 0; i < s1.Length; i++)
        {            if (s1[i] != s2[i])
                return false;
        }
        return true;
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var visited = new bool[strs.Length];

        for (var i = 0; i < strs.Length; i++)
        {
            if (visited[i]) continue;
            var word = strs[i];
            var sWord = word.ToCharArray();
            Array.Sort(sWord);
            var l = new List<string>() {word};
            visited[i] = true;

            for (var j = i + 1; j < strs.Length; j++)
            {
                if (visited[j]) continue;
                var s = strs[j].ToCharArray();
                Array.Sort(s);
                if (IsAnagram(sWord, s)) {
                    l.Add(strs[j]);
                    visited[j] = true;
                }
            }

            result.Add(l);
        }

        return result;
    }
}