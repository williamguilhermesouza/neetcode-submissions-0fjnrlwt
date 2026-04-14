public class Solution {
    public int HammingWeight(uint n) {
        int c = 0;
        while (n != 0)
        {
            c += (int) n % 2;
            n >>>= 1;
        }

        return c;
    }
}
