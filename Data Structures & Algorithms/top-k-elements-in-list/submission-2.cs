public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var key = nums[i];
            freqMap[key] = freqMap.GetValueOrDefault(key) + 1;
        }
        return freqMap
        .OrderByDescending(x => x.Value)
        .Select(x => x.Key)
        .Take(k)
        .ToArray();
    }
}
