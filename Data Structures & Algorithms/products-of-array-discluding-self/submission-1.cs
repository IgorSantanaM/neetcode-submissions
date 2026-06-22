public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        Array.Fill(res, 1);
        int prefix = 1;
        for(int i = 1; i < res.Length; i++)
        {
            res[i] = prefix * nums[i - 1];
            prefix *= nums[i - 1];
            
        }

        int postfix = 1;

        for(int i = res.Length - 1; i >= 0; i--)
        {
            res[i] *= postfix;
            postfix *= nums[i];
        }

        return res;
    }
}
