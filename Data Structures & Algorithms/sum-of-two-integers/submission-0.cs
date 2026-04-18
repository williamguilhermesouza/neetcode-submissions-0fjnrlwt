public class Solution {
    public int GetSum(int a, int b) {
        while(b != 0)
        {
            var temp = (a & b) << 1;
            a = a^b;
            b = temp;
        }

        return a;
    }
}
