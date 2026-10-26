class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        lenn = len(nums)
        ans = []

        prod = 1
        for i in range(lenn):
            ans.append(prod)
            prod *= nums[i]

        prod = 1
        for i in reversed(range(lenn)):
            ans[i] *= prod
            prod *= nums[i]

        return ans