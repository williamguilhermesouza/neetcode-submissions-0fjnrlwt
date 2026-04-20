public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        var L = 0;
        var R = matrix[0].Length;
        var T = 0;
        var B = matrix.Length;

        var res = new List<int>();

        while(L < R && T < B)
        {
            for(var i = L; i < R; i++)
            {
                res.Add(matrix[T][i]);
            }
            T++;

            for(var i = T; i < B; i++)
            {
                res.Add(matrix[i][R-1]);
            }
            R--;

            if (!(L < R && T < B))
            {
                break;
            }

            for (var i = R-1; i > L-1; i--)
            {
                res.Add(matrix[B-1][i]);
            }
            B--;

            for(var i = B -1; i > T-1; i--)
            {
                res.Add(matrix[i][L]);
            }
            L++;

        }

        return res;
    }
}
