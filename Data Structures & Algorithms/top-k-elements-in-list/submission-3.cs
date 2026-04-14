public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var key = nums[i];
            freqMap[key] = freqMap.GetValueOrDefault(key) + 1;
        }

        var freqBuckets = new List<int>[nums.Length + 1];
        foreach(var (value, freq) in freqMap)
        {
            if(freqBuckets[freq] is not {} list)
            {
                list = freqBuckets[freq] = new List<int>();
            }

            list.Add(value);
        }

        var result = new List<int>(capacity: k);
        for(var i = nums.Length; i > 0; i--)
        {
            IReadOnlyList<int> values = freqBuckets[i] ?? [];
            foreach(var value in values)
            {
                result.Add(value);
                if(result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }

        return result.ToArray();

    }
}
