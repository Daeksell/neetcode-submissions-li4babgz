public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int, int>();
        var numsSpan = nums.AsSpan();
        for(int i = 0; i < nums.Length; i++)
        {
            var missing = target - numsSpan[i];
            if(map.TryGetValue(missing, out var leftIndex))
            {
                return new int[] {leftIndex, i};
            }
            map.Add(numsSpan[i], i);
        }
        return Array.Empty<int>();
    }
}
