class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        # O(n) space
        counter = [0] * (len(nums) + 1)

        for n in nums:
            counter[n] += 1
            if counter[n] > 1:
                return n


