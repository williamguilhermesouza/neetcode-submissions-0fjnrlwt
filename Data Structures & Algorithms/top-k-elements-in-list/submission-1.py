class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        top = []
        top_freq = []
        counter = {}

        for n in nums:
            counter[n] = counter.get(n, 0) + 1
            
            if n in top:
                i = top.index(n)
                top_freq[i] += 1
            elif len(top) < k:
                top.append(n)
                top_freq.append(counter[n])
            elif counter[n] > min(top_freq):
                m = min(top_freq)
                i = top_freq.index(m)
                top[i] = n
                top_freq[i] = counter[n]

        return top

