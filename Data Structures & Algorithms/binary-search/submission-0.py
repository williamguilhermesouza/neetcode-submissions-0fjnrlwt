class Solution:
    def search(self, nums: List[int], target: int) -> int:
        
        def binS(s: int, e: int):
            if s == e and nums[s] != target:
                return -1

            im = (e - s) // 2 + s
            m = nums[im]
            if m == target:
                return im
            
            if m > target:
                return binS(s, im)
            else:
                return binS(im + 1, e)
        
        return binS(0, len(nums) - 1)
