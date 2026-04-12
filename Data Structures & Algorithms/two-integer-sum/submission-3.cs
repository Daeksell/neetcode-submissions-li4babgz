public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int, int>(nums.Length);
        for(int i = 0; i < nums.Length; i++)
        {
            var missing = target - nums[i];
            if(map.TryGetValue(missing, out var leftIndex))
            {
                return new int[] {leftIndex, i};
            }
            map.Add(nums[i], i);
        }
        return Array.Empty<int>();
    }
}
