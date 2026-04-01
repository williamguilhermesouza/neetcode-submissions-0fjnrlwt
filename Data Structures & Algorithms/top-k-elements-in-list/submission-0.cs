public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var counter = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            counter[nums[i]] = counter.GetValueOrDefault(nums[i], 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(var kv in counter)
        {
            var freq = kv.Value;

            if (buckets[freq] == null)
                buckets[freq] = new List<int>();
            
            buckets[freq].Add(kv.Key);
        }

        var result = new List<int>();
        for (var i = buckets.Length; i > 0; --i)
        {
            if (buckets[i] == null) continue;
            
            foreach(var b in buckets[i])
            {
                result.Add(b);
                if (result.Count >= k) return result.ToArray();
            }
        }

        return result.ToArray();
        
    }
}
