class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        complement = {}

        for i, n in enumerate(nums):
            complement[n] = i
        
        for i, n in enumerate(nums):
            c = target - n

            if c in complement.keys() and complement[c] != i:
                return [i, complement[c]]
        
        return []