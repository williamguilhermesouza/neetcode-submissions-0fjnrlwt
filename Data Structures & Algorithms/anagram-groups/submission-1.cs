public class Solution {
    
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var letters = new int[26];

            foreach(var l in word)
            {
                var lIndex = (int)l;
                letters[lIndex - (int)'a']++;
            }

            string key = string.Join(",", letters);

            if (map.TryGetValue(key, out var group))
                group.Add(word);
            else
            {
                var li = new List<string> {word};
                map.Add(key, li);
            }
        }

        List<List<string>> result = map.Values.ToList();
        return result;
    }
}