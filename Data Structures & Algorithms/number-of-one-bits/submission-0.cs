public class Solution {
    public int HammingWeight(uint n) {
        var c = 0;
        while(n != 0)
        {
            n &= (n-1);
            c++;
        }

        return c;

    }
}
