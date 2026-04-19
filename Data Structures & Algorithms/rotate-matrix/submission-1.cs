public class Solution {
    public void Rotate(int[][] matrix) {
        if (matrix.Length == 0) return;

        int R = matrix.Length;
        int C = matrix[0].Length;

        var l = 0;
        var r = R - 1;

        while (l < r)
        {
            for(var i = 0; i < r - l; i++)
            {
                var top = l;
                var bottom = r;

                var topLeft = matrix[top][l + i];

                matrix[top][l+i] = matrix[bottom-i][l];
                matrix[bottom-i][l] = matrix[bottom][r-i];

                matrix[bottom][r-i] = matrix[top+i][r];

                matrix[top+i][r] = topLeft;

            }
            r--;
            l++;
        }
    }
}
