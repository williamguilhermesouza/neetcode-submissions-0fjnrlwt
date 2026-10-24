class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        counter = {}

        for n in nums:
            counter[n] = counter.get(n, 0) + 1

        bucket = [[] for _ in  range(len(nums) +1)]
        for n, f in counter.items():
            bucket[f].append(n)


        res = []
        for top in bucket[::-1]:
            for n in top:
                res.append(n)

                if len(res) >= k:
                    return res
        
        return res



