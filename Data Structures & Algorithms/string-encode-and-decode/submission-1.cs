public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (var s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();

        var i = 0;
        while(i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }
            
            int count = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            result.Add(s.Substring(i, count));
            i = i + count;
        }

        return result;
   }
}