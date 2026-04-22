class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:

        for row in board:
            seen = {}

            for n in row:
                if n == '.': continue
                seen[n] = seen.get(n, 0) + 1
                if seen[n] > 1:
                    return False

        for col in range(len(board[0])):
            seen = {}

            for row in board:
                n = row[col]
                if n == '.': continue
                seen[n] = seen.get(n, 0) + 1
                if seen[n] > 1:
                    return False
        
        for offsetX in range(3):
            for offsetY in range(3):
                
                seen = {}

                for r in range(offsetY*3, offsetY*3 + 3):
                    row = board[r]

                    for c in range(offsetX*3, offsetX*3 + 3):
                        n = row[c]
                        if n == '.': continue
                        seen[n] = seen.get(n, 0) +1
                        if seen[n] > 1:
                            return False


        return True