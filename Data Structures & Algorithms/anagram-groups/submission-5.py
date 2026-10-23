class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        grouped = {}

        for st in strs:
            freq = [0] * 26

            for l in st:
                freq[ord(l) - ord('a')] += 1

            key = tuple(freq)
            grouped[key] = grouped.get(key, [])
            grouped[key].append(st)

        return list(grouped.values())



            
                



