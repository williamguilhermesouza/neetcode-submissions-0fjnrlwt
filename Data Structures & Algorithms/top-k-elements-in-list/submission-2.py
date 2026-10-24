class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        
        counter = {}

        for n in nums:
            counter[n] = counter.get(n, 0) + 1

        heap = []
        for n, f in counter.items():
            heapq.heappush(heap, (f,n))

            if len(heap) > k:
                heapq.heappop(heap)

        return [n for _, n in heap]

