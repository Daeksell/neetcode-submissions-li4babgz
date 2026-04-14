public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       var wholeProduct = 1;
       var zeroCount = 0;
       for(int i = 0; i < nums.Length; i++)
       {
            if(nums[i] == 0)
            {
                zeroCount++;
                if(zeroCount > 1)
                {
                    return new int[nums.Length];
                }
                continue;
            }

            wholeProduct *= nums[i];
        } 
        var result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                result[i] = wholeProduct;
                continue;
            }

            result[i] =  zeroCount > 0 
            ? 0 
            : (wholeProduct / nums[i]);
        }
        return result;
    }
}
