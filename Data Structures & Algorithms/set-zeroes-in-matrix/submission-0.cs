public class Solution {
    public void SetZeroes(int[][] matrix) {
        for(var i = 0; i < matrix.Length; i++)
        {
            for(var j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    for(var n = 0; n < matrix[0].Length; n++)
                    {
                        if (matrix[i][n] != 0)
                        {
                            matrix[i][n] = -1;
                        }
                    }
                    for(var m = 0; m < matrix.Length; m++)
                    {
                        if (matrix[m][j] != 0)
                            matrix[m][j] = -1;
                    }
                }
            }
        }

        for(var i = 0; i < matrix.Length; i++)
        {
            for(var j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == -1)
                    matrix[i][j] = 0;
            }
        }
        
    }
}
