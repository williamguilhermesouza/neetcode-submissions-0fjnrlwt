class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        grouped: dict[str, list[str]] = {}

        for s in strs:
            s_sort = str(sorted(s))

            grouped[s_sort] = grouped.get(s_sort, [])
            l = grouped[s_sort]
            l.append(s)

        return list(grouped.values())


            
                



