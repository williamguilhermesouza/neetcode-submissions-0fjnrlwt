class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        rows = [False for n in range(len(matrix))]
        cols = [False for n in range(len(matrix[0]))]

        for i in range(len(matrix)):
            for j in range(len(matrix[0])):
                if matrix[i][j] == 0:
                    rows[i] = True
                    cols[j] = True

        for i in range(len(matrix)):
            for j in range(len(matrix[0])):
                if rows[i] or cols[j]:
                    matrix[i][j] = 0
        
        