class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        s = 0
        f = 1

        while s != len(nums):
            if nums[s] == nums[f]:
                return nums[s]
            
            f += 1
            if f >= len(nums):
                s += 1
                f = s + 1

