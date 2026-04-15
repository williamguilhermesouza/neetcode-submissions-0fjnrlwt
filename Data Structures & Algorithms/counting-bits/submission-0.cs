public class Solution {
    public int[] CountBits(int n) {
        var res = new int[n + 1];

        foreach(var i in Enumerable.Range(0, n + 1))
        {
            var c = 0;
            var x = i;
            while(x != 0)
            {
                x &= (x-1);
                c++;
            }

            res[i] = c;
        }

        return res;
    }
}
