class Solution:

    def encode(self, strs: List[str]) -> str:
        ans = []
        sep = '-'
        for s in strs:
            size = len(s)
            ans.append(str(size))
            ans.append(sep)
            ans.append(s)
        
        return ''.join(ans)

    def decode(self, s: str) -> List[str]:
        ans = []
        sep = '-'
        i = 0
        while i < len(s):
            size = 0
            n = []
            while s[i] != sep: 
                n += s[i]
                i += 1
            size = int(''.join(n))
            i += 1
            ans.append(s[i:size +i])
            i += size
        return ans
        