class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        lookup = set(nums)
        m = 0

        for n in nums:
            t = n
            local = 0            
            while t - 1 in lookup:
                t = t -1
            
            while t in lookup:
                local += 1
                lookup.remove(t)
                t += 1
            
            m = max(m, local)

        return m



                
