public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0') return 0;
        
        var prev = 1;
        var cur = 1;

        for (var i = 1; i < s.Length; i++)
        {
            var temp = 0;

            if (s[i] != '0')
                temp = cur;
            
            var two = (s[i - 1] - '0') * 10 + (s[i] - '0');

            if (two >= 10 && two <= 26)
                temp += prev;

            prev = cur;
            cur = temp;
        }

        return cur;
    }
}
